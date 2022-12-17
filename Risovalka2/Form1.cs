using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Risovalka2
{
    public partial class Form1 : Form
    {
        int countClick = 0;
        List<Point> points = new List<Point>();
        private CSpline _model;
        public Color ColorLine { get; set; } = Color.Black;
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
        static public void BresenhamLine(Graphics g, Color clr, int x0, int y0,
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
            countClick++;
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, points[countClick - 1].X, points[countClick - 1].Y, 2, 2);
            if (points.Count > 4)
            {
                rbCurveBize.Checked = false;
                rbBizeN.Checked = true;
            }
        }

        public static void DrawWuLine(Graphics g, Color clr, int x0, int y0, int x1, int y1)
        {
            //Вычисление изменения координат
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            //Если линия параллельна одной из осей, рисуем обычную линию - заполняем все пикселы в ряд
            if (dx == 0 || dy == 0)
            {
                g.DrawLine(new Pen(clr), x0, y0, x1, y1);
                return;
            }

            //Для Х-линии (коэффициент наклона < 1)
            if (dy < dx)
            {
                //Первая точка должна иметь меньшую координату Х
                if (x1 < x0)
                {
                    x1 += x0; x0 = x1 - x0; x1 -= x0;
                    y1 += y0; y0 = y1 - y0; y1 -= y0;
                }
                //Относительное изменение координаты Y
                float grad = (float)dy / dx;
                //Промежуточная переменная для Y
                float intery = y0 + grad;
                //Первая точка
                PutPixel(g, clr, x0, y0, 255);

                for (int x = x0 + 1; x < x1; x++)
                {
                    //Верхняя точка
                    PutPixel(g, clr, x, RasterAlgorithms.IPart(intery), (int)(255 - RasterAlgorithms.FPart(intery) * 255));
                    //Нижняя точка
                    PutPixel(g, clr, x, RasterAlgorithms.IPart(intery) + 1, (int)(RasterAlgorithms.FPart(intery) * 255));
                    //Изменение координаты Y
                    intery += grad;
                }
                //Последняя точка
                PutPixel(g, clr, x1, y1, 255);
            }
            //Для Y-линии (коэффициент наклона > 1)
            else
            {
                //Первая точка должна иметь меньшую координату Y
                if (y1 < y0)
                {
                    x1 += x0; x0 = x1 - x0; x1 -= x0;
                    y1 += y0; y0 = y1 - y0; y1 -= y0;
                }
                //Относительное изменение координаты X
                float grad = (float)dx / dy;
                //Промежуточная переменная для X
                float interx = x0 + grad;
                //Первая точка
                PutPixel(g, clr, x0, y0, 255);

                for (int y = y0 + 1; y < y1; y++)
                {
                    //Верхняя точка
                    PutPixel(g, clr, RasterAlgorithms.IPart(interx), y, 255 - (int)(RasterAlgorithms.FPart(interx) * 255));
                    //Нижняя точка
                    PutPixel(g, clr, RasterAlgorithms.IPart(interx) + 1, y, (int)(RasterAlgorithms.FPart(interx) * 255));
                    //Изменение координаты X
                    interx += grad;
                }
                //Последняя точка
                PutPixel(g, clr, x1, y1, 255);
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            if (e.Button == MouseButtons.Right)
            {
                if (rbBrezenhem.Checked)
                {
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        BresenhamLine(g, ColorLine, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
                    }
                }
                else if (rbBrizenhemPlus.Checked)
                {
                    for (int i = 0; i < points.Count; i++)
                    {
                        DrawWuLine(g, ColorLine, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
                    }
                }
                // Кривая по 4 точкам
                else if (rbCurveBize.Checked && points.Count == 4)
                {
                    PointF[] pointFs = new PointF[4];
                    for (int i = 0; i < points.Count; i++)
                    {
                        pointFs[i] = points[i];
                    }
                    BezierCurve curve = new BezierCurve(pointFs);
                    curve.Draw(g);
                }
                // Кривая Бизье n порядка
                else if (rbBizeN.Checked)
                {
                    List<PointF> pointFs = new List<PointF>();
                    BezierCurve curve = new BezierCurve(pointFs);
                    foreach (var item in points)
                    {
                        pointFs.Add(item);
                    }
                    curve.dataPointsN = pointFs;
                    g = Graphics.FromHwnd(pictureBox1.Handle);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    curve.DrawN(g, ColorLine);
                }
            }
        }
        #region Splines

        private void SetD1ToModel()
        {
            _model.Df1 = (double)vScrollBar1.Value / 1000;
            _model.Dfn = (double)vScrollBar2.Value / 1000;
            _model.GenerateSplines(ColorLine);
        }

        private void GetDerivatesFromModel()
        {
            textBox_df1.Text = $"{-_model.Df1:0.0000}";
            textBox_dfn.Text = $"{-_model.Dfn:0.0000}";
            textBox_ddf1.Text = $"{-_model.Ddf1:0.0000}";
            textBox_ddfn.Text = $"{-_model.Ddfn:0.0000}";
        }

        private void Draw()
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            var canvas = Graphics.FromImage(bmp);

            _model.Draw(canvas);

            pictureBox1.Image = bmp;
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            var random = new Random();

            var spline = new CPoint[points.Count];
            var interval = (pictureBox1.Width - 20) / points.Count;

            for (var i = 0; i < points.Count; i++)
            {
                spline[i] = new CPoint(points[i].X, points[i].Y);
            }

            _model = new CSpline(spline);

            vScrollBar1.Value = 0;
            vScrollBar2.Value = 0;

            if (points.Count > 1)
            {
                SetD1ToModel();
                GetDerivatesFromModel();
                Draw();
            }
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null)
            {
                SetD1ToModel();
                GetDerivatesFromModel();
                Draw();
            }
        }

        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null)
            {
                SetD1ToModel();
                GetDerivatesFromModel();
                Draw();
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ColorLine = colorDialog1.Color;
            pictureBox2.BackColor = ColorLine;
        }

        private void pictureBox2_BackColorChanged(object sender, EventArgs e)
        {
            CSplineSubinterval.ColorLine = ColorLine;
            if (_model != null & points.Count > 1)
            {
                SetD1ToModel();
                GetDerivatesFromModel();
                Draw();
            }
        }
    }
}
