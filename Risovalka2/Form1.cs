using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Risovalka2
{
    public partial class Form1 : Form
    {
        int countClick = 0;
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        //Метод, устанавливающий пиксел на форме с заданными цветом и прозрачностью
        private static void PutPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }

        //Статический метод, реализующий отрисовку 4-связной линии
        static public void Bresenham4Line(Graphics g, Color clr, int x0, int y0,
                                                                 int x1, int y1)
        {
            //Изменения координат
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            //Направление приращения
            int sx = (x1 >= x0) ? (1) : (-1);
            int sy = (y1 >= y0) ? (1) : (-1);

            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0 + sx;
                int y = y0;
                for (int i = 1; i <= dx; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        y += sy;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    x += sx;
                }
            }
            else
            {
                int d = (dx << 1) - dy;
                int d1 = dx << 1;
                int d2 = (dx - dy) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0;
                int y = y0 + sy;
                for (int i = 1; i <= dy; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        x += sx;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    y += sy;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            txtArray.Clear();
            points.Add(new Point(e.X, e.Y));

            foreach (var item in points)
            {
                txtArray.Text += $"X: {item.X}  \nY: {item.Y}" + Environment.NewLine;
            }
            if (countClick > 0)
            {
                Bresenham4Line(g, Color.Black, points[countClick - 1].X, points[countClick - 1].Y, points[countClick].X, points[countClick].Y);
            }
            countClick++;
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, points[countClick - 1].X, points[countClick - 1].Y, 2, 2);

            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    g.FillRectangle(brush, points[i].X, points[i++].Y, 2, 2);
                }
            }
        }
    }
}
