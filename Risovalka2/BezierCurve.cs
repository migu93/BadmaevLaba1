using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risovalka2
{
    /// <summary>
    /// Кривоая безье
    /// </summary>
    public class BezierCurve
    {
        /// <summary>
        /// Количество точек для отрисовки.
        /// </summary>
        private const int N = 40;

        /// <summary>
        /// Опорные точки.
        /// </summary>
        private PointF[] dataPoints;
        public List<PointF> dataPointsN;

        /// <summary>
        /// Создание кривой безье
        /// </summary>
        /// <param name="points">Опроные точки</param>
        public BezierCurve(PointF[] points)
        {
            if (points.Length != 4)
            {
                throw new ArgumentOutOfRangeException();
            }
            dataPoints = points;
            Invalidate();
        }
        public BezierCurve(List<PointF> points)
        {
            dataPointsN = points;
        }

        /// <summary>
        /// Точки для отрисовки
        /// </summary>
        public PointF[] DrawingPoints { get; private set; }

        /// <summary>
        /// Опорные точки
        /// </summary>
        public PointF[] DataPoints
        {
            get { return dataPoints; }
            set
            {
                if (value.Length != 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dataPoints = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Опорная точка
        /// </summary>
        /// <param name="i">Индекс опорной точки</param>
        public PointF this[int i]
        {
            get { return dataPoints[i]; }
            set
            {
                dataPoints[i] = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Обновить точки для отрисовки.
        /// </summary>
        public void Invalidate()
        {
            DrawingPoints = new PointF[N + 1];
            float dt = 1f / N;
            float t = 0f;
            for (int i = 0; i <= N; i++)
            {
                DrawingPoints[i] = B(t);
                t += dt;
            }
        }

        /// <summary>
        /// Функция кривой
        /// </summary>
        /// <param name="t">Параметр. Может изменяться от 0 до 1</param>
        /// <returns>Точка кирвой</returns>
        private PointF B(float t)
        {
            float c0 = (1 - t) * (1 - t) * (1 - t);
            float c1 = (1 - t) * (1 - t) * 3 * t;
            float c2 = (1 - t) * t * 3 * t;
            float c3 = t * t * t;
            float x = c0 * dataPoints[0].X + c1 * dataPoints[1].X + c2 * dataPoints[2].X + c3 * dataPoints[3].X;
            float y = c0 * dataPoints[0].Y + c1 * dataPoints[1].Y + c2 * dataPoints[2].Y + c3 * dataPoints[3].Y;
            return new PointF(x, y);
        }

        /// <summary>
        /// Отрисовка кривой.
        /// </summary>
        /// <param name="g">График для отрисовки</param>
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2f);
            g.DrawLines(pen, DrawingPoints);
        }
        int Fuctorial(int n) // Функция вычисления факториала
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }
        float polinom(int i, int n, float t)// Функция вычисления полинома Бернштейна
        {
            return (Fuctorial(n) / (Fuctorial(i) * Fuctorial(n - i))) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, n - i);
        }
        public void DrawN(Graphics g, Color color)// Функция рисования кривой
        {
            int j = 0;
            float step = 0.01f;// Возьмем шаг 0.01 для большей точности

            PointF[] result = new PointF[101];//Конечный массив точек кривой
            for (float t = 0; t < 1; t += step)
            {
                float ytmp = 0;
                float xtmp = 0;
                for (int i = 0; i < dataPointsN.Count; i++)
                { // проходим по каждой точке
                    float b = polinom(i, dataPointsN.Count - 1, t); // вычисляем наш полином Бернштейна
                    xtmp += dataPointsN[i].X * b; // записываем и прибавляем результат
                    ytmp += dataPointsN[i].Y * b;
                }
                result[j] = new PointF(xtmp, ytmp);
                j++;

            }
            g.DrawLines(new Pen(color), result);// Рисуем полученную кривую Безье
        }
    }
}
