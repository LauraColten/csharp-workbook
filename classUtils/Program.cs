using System;

namespace classUtils
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.printMessage("Hi, this is a string!");
            Utils.errorMessage("Oops!");
            Utils message = new Utils();
            message.debug("You have a bug");
        }
    }

    class Utils
    {
        public static string msgPrefix = ">";
        public static void printMessage(string msg)
        {
            Console.WriteLine(msgPrefix+msg);
        }

        public static void errorMessage(string err)
        {
            Console.WriteLine("[error: " +err+ "]");
        }

        public void debug(string msg)
        {
            Console.WriteLine("[debug log msg: {0}]", msg);
        }
    }
}
