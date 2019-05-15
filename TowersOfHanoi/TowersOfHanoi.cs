using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {


            Game g1 = new Game();
            g1.movePiece("A", "B");




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

            Tower a = new Tower();
            a.blocks.Push(b4);
            a.blocks.Push(b3);
            a.blocks.Push(b2);
            a.blocks.Push(b1);
            towers.Add("A", a);

            Tower b = new Tower();
            Tower c = new Tower();
            towers.Add("B", b);
            towers.Add("C", c);

        }

        public void movePiece(string sourceTowerName, string destinationTowerName)
        {
            Tower x = towers[sourceTowerName];
            Tower y = towers[destinationTowerName];
            bool IsLegalMove = IsLegal(x, y);
            if(IsLegalMove) {
                Block blockToMove = x.blocks.Pop();
                y.blocks.Push(blockToMove);
            }


        }
        public bool IsLegal(Tower from, Tower to)
        {
        if (from.blocks.Count == 0 && to.blocks.Count == 0){
            return false;
        }else if (from.blocks.Count == 0) {
            return false;
        }else if (to.blocks.Count == 0) {
            return true;
        }else if (from.blocks.Peek().weight < to.blocks.Peek().weight){
            return true;
        }else{
            return false;
        }

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
