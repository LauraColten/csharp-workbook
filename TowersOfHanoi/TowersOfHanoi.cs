using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {


            Game g1 = new Game();


            g1.printKeysAndWeights();

        }

    class Block
    {
        public int weight;
        public Block(int initialWeight)
        {
            this.weight = initialWeight;
        }
    }

    class Tower
    {
        public Stack<Block> blocks;
        public Tower()
        {
            blocks = new Stack<Block>();
        }
        public String toString()
        {
            string s = "";
            foreach(Block b in blocks) {
                s = s+" "+b.weight;
            }
            return s;
        }
    }

    class Game
    {
        public Dictionary<string, Tower> towers = new Dictionary<string, Tower>();

        public Game()
        {
            Block b1 = new Block(1);
            Block b2 = new Block(2);
            Block b3 = new Block(3);
            Block b4 = new Block(4);

            towers["A"] = new Tower();
            towers["A"].blocks.Push(b4);
            towers["A"].blocks.Push(b3);
            towers["A"].blocks.Push(b2);
            towers["A"].blocks.Push(b1);

            towers["B"] = new Tower();
            towers["C"] = new Tower();
        }

        public string popOff;
        public string popOn;
        public void movePiece(string initialPopOff, string initialPopOn)
        {

            Block block = towers[initialPopOff].blocks.Pop();
            towers[initialPopOn].blocks.Push(block);

        }


        public void printKeysAndWeights()
        {
            foreach(KeyValuePair<string, Tower> entry in towers)
            {
                Console.WriteLine(entry.Key);
                foreach(Block block in entry.Value.blocks) {
                    Console.WriteLine(block.weight);
                }
            }
        }

    }
    }
}
