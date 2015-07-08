using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace AutoCad_Lookalike
{
    class Prim
    {
        private int x1, y1, x2, y2;

        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public Prim() { }
        public Prim(int a, int b, int c, int d)
        {
            x1 = a;
            y1 = b;
            x2 = c;
            y2 = d;
        }
        private bool draws = true;
        //Linha
        public void draw(Graphics g, Pen p)
        {
            if (draws)
            {
                g.DrawLine(p, new Point(x1, y1), new Point(x2, y2));
            }
        }
        //triangulo
        public void drawTriangle(Graphics g, Pen p)
        {
            if (draws)
            {
                g.DrawLine(p, new Point(x1, y1), new Point(x1+(x2/2), (y1+y2)));
                g.DrawLine(p, new Point(x1, y1), new Point(x1-(x2/2), (y1+y2)));
                g.DrawLine(p, new Point(x1-(x2/2), (y1+y2)), new Point(x1+(x2/2), (y1+y2)));
            }
        }
        //Rectangulo
        public void drawSquare(Graphics g, Pen p)
        {
            if (draws)
            {
                g.DrawLine(p, new Point(x1, y1), new Point(x2, y1));
                g.DrawLine(p, new Point(x1, y2), new Point(x2, y2));
                g.DrawLine(p, new Point(x1, y1), new Point(x1, y2));
                g.DrawLine(p, new Point(x2, y1), new Point(x2, y2));
            }
        }
       
        public void undo()
        {
            draws = false;
        }
    }
}
