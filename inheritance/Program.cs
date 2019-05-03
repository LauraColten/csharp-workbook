using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPoint p1 = new TwoDPoint(6, 7);
            ThreeDPoint p2 = new ThreeDPoint(8, 9, 10);

            TwoDPoint p3 = new TwoDPoint(3, 4);

            Console.WriteLine("p1 = {0}", p1);//.ToString());with override this is done for you
            Console.WriteLine("p2 = {0}", p2);//.ToString());

        }
    }

    public class TwoDPoint
    {
        public int x;
        public int y;


        public TwoDPoint(int initialX, int initialY)
        {
            this.x = initialX;
            this.y = initialY;
        }
        override public string ToString()
        {
            string s = string.Format("({0}), ({1})", x, y);
            return s;
        }

    }

    public class ThreeDPoint : TwoDPoint
    {
        public int z;


        public ThreeDPoint(int x, int y, int initialZ) : base(x, y) {
            z = initialZ;
        }

        override public string ToString()
        {
            string s = string.Format("({0}), ({1}), ({2})", x, y, z);
            return s;
        }
    }
}
