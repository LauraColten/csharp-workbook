using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Block b1 = new Block(1);
            Block b2 = new Block(2);

            Tower towerA = new Tower();
            towerA.blocks.Push(b2);
            towerA.blocks.Push(b1);
        }
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

        }

    }

}
