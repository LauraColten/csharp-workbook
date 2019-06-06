using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
  class Program
  {
    static void Main(string[] args)
    {
      App app = new App();
      app.start();
    }
  }
  class App
  {
    public void start()
    {
      Utils utils = new Utils();
      Dao dao = new Dao();
      string choice;
      do
      {
        utils.menu();
        choice = utils.getInput();
        if (choice == "1")
        {
          utils.printItems(dao.listItems());
        }
        else if (choice == "2")
        {
          utils.printStringMessage();
          string newItem = utils.getInput();
          dao.create(newItem, Type.NotStarted);
        }
        else if (choice == "3")
        {
          utils.printIdMessage();
          int idChoice = Convert.ToInt32(utils.getInput());
          dao.inProgress(idChoice);
        }
        else if (choice == "4")
        {
          utils.printIdMessage();
          int idChoice = Convert.ToInt32(utils.getInput());
          dao.complete(idChoice);
        }
        else if (choice == "5")
        {
          int idChoice = Convert.ToInt32(utils.getInput());
          utils.printIdMessage();
          dao.delete(idChoice);
        }
        else if (choice == "6")
        {
          utils.printInProgress(dao.listItems());
        }
        else if (choice == "7")
        {
          utils.printCompleted(dao.listItems());
        }
        else
        {
          utils.printErrorMessage();
        }
        Console.WriteLine("Press enter to choose again.");
        utils.getInput();
      } while (choice != "8");
    }
  }

  public class ToDo
  {
    public int id { get; private set; }
    public string item { get; private set; }
    public Type status { get; set; }

    public ToDo()
    {

    }
    public ToDo(string initialItem, Type initialStatus)
    {
      this.item = initialItem;
      this.status = initialStatus;
    }
  }

  public enum Type
  {
    NotStarted = 1,
    InProgess = 2,
    Completed = 3
  }


  public class Utils
  {
    public void menu()
    {
      Console.WriteLine("Please choose a number from the following options: \n (1) Print To do list. \n (2) Add an item. \n (3) Mark an item as In progress. \n (4) Mark an item as completed. \n (5) Delete an item by id. \n (6) Print the list of in progress items. \n (7) Print the list of completed items.\n (8) Exit.");

    }

    public void printItems(IEnumerable<ToDo> listItems)
    {
      foreach (ToDo b in listItems)
      {
        Console.WriteLine(b.id + " " + b.item + " is " + b.status);
      }

    }

    public void printInProgress(IEnumerable<ToDo> inProgessItems)
    {
      foreach (ToDo b in inProgessItems)
      {
        if (b.status == Type.InProgess)
        {
          Console.WriteLine(b.id + " " + b.item + " is " + b.status);
        }
      }
    }

    public void printCompleted(IEnumerable<ToDo> completedItems)
    {
      foreach (ToDo b in completedItems)
      {
        if (b.status == Type.Completed)
        {
          Console.WriteLine(b.id + " " + b.item + " is " + b.status);
        }
      }
    }

    public void printStringMessage()
    {
      Console.WriteLine("Enter the new item: ");
    }

    public void printIdMessage()
    {
      Console.WriteLine("Enter the id of the item: ");
    }

    public void printErrorMessage()
    {
      Console.WriteLine("Please enter a valid menu choice.");
    }

    public string getInput()
    {
      // Console.WriteLine("Please enter a choice: ");
      string s = Console.ReadLine();
      return s;
    }
  }

  public class Dao
  {
    private ToDoContext context;
    public Dao()
    {
      context = new ToDoContext();
      context.Database.EnsureCreated();
    }

    public void create(string item, Type status)
    {
      ToDo newItem = new ToDo(item, status);
      context.todos.Add(newItem);
      context.SaveChanges();
    }

    public void complete(int id)
    {
      foreach (ToDo b in context.todos)
      {
        if (id == b.id)
        {
          b.status = Type.Completed;
        }
      }
      context.SaveChanges();

    }

    public void inProgress(int id)
    {
      foreach (ToDo b in context.todos)
      {
        if (id == b.id)
        {
          b.status = Type.InProgess;
        }
      }
      context.SaveChanges();

    }

    public void delete(int id)
    {
      foreach (ToDo b in context.todos)
      {
        if (id == b.id)
        {
          context.Remove(b);
        }
      }
      context.SaveChanges();

    }

    public IEnumerable<ToDo> listItems()
    {
      List<ToDo> result = new List<ToDo>();
      foreach (ToDo b in context.todos)
      {
        result.Add(b);
      }
      return result;
    }

    public List<ToDo> listInProgress()
    {
      List<ToDo> inProgessItems = new List<ToDo>();

      foreach (ToDo b in context.todos)
      {
        if (b.status == Type.InProgess)
        {
          inProgessItems.Add(b);
        }
      }
      return inProgessItems;
    }


    public class ToDoContext : DbContext
    {
      public DbSet<ToDo> todos { get; private set; }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        optionsBuilder.UseSqlite("Filename=./ToDo.db");
      }
    }

  }












}