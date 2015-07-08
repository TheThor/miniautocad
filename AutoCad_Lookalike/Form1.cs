using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace AutoCad_Lookalike
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Black, 1);  //diz que p é um objecto do tipo pen com espessura 1 e de cor preta
        Graphics g; //cria um objecto do tipo graficos
        Prim[] prims = new Prim[1000];
        int indexPrim = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoxE.Text != "")
            {
                int esp = int.Parse(BoxE.Text);
                p=new Pen(Color.Black, esp);
            }
            int x1 = int.Parse(Box_x1.Text);
            int y1 = int.Parse(Box_y1.Text);
            int x2 = int.Parse(Box_x2.Text);
            int y2 = int.Parse(Box_y2.Text);
            if (x1 >= 0 && x1 <= 512 && y1 >= 0 && y1 <= 512 && x2 >= 0 && x2 <= 512 && y2 >= 0 && y2 <= 512)
            {
                indexPrim++;
                prims[indexPrim] = new Prim(x1, y1, x2, y2);
                g = panel1.CreateGraphics();
                prims[indexPrim].draw(g, p);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BoxE.Text != "")
            {
                int esp = int.Parse(BoxE.Text);
                p = new Pen(Color.Black, esp);
            }
            int x1 = int.Parse(Box_x1.Text);
            int y1 = int.Parse(Box_y1.Text);
            int x2 = int.Parse(Box_x2.Text);
            int y2 = int.Parse(Box_y2.Text);
            if (x1 >= 0 && x1 <= 512 && y1 >= 0 && y1 <= 512 && x2 >= 0 && x2 <= 512 && y2 >= 0 && y2 <= 512)
            {
                indexPrim++;
                prims[indexPrim] = new Prim(x1, y1, x2, y2);
                g = panel1.CreateGraphics();
                prims[indexPrim].drawTriangle(g, p);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BoxE.Text != "")
            {
                int esp = int.Parse(BoxE.Text);
                p = new Pen(Color.Black, esp);
            }
            int x1 = int.Parse(Box_x1.Text);
            int y1 = int.Parse(Box_y1.Text);
            int x2 = int.Parse(Box_x2.Text);
            int y2 = int.Parse(Box_y2.Text);
            if (x1 >= 0 && x1 <= 512 && y1 >= 0 && y1 <= 512 && x2 >= 0 && x2 <= 512 && y2 >= 0 && y2 <= 512)
            {
                indexPrim++;
                prims[indexPrim] = new Prim(x1, y1, x2, y2);
                g = panel1.CreateGraphics();
                prims[indexPrim].drawSquare(g, p);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (BoxE.Text != "")
            {
                int esp = int.Parse(BoxE.Text);
                p = new Pen(Color.Black, esp);
            }
            int x1 = int.Parse(Box_x1.Text);
            int y1 = int.Parse(Box_y1.Text);
            int x2 = int.Parse(Box_x2.Text);
            int y2 = int.Parse(Box_y2.Text);
            if (x1 >= 0 && x1 <= 512 && y1 >= 0 && y1 <= 512 && x2 >= 0 && x2 <= 512 && y2 >= 0 && y2 <= 512)
            {
                Graphics g = panel1.CreateGraphics();
                g.DrawEllipse(p,x1,y1,x2,y2);
            }
        }
    }
}
