using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    internal class Cell
    {
        static public int CS = 40;

        public int Y;
        public int X;

        public int patNo { get; set; } = -1;
        public bool SetFlag { get; set; } = false;

        Rectangle Rt;
        Rectangle[] ImgRt;
        Bitmap BackBit, PlayBit, ImgBit;

        public void init(int x,int y)
        {
            X = x;
            Y = y;
            Rt = new Rectangle(x * CS, y * CS, CS, CS);
        }

    }
}
