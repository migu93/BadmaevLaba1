using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risovalka2
{
    internal class CSpline : IDraw
    {
        private readonly CPoint[] _points;
        private readonly CSplineSubinterval[] _splines;
        public Color ColorSpline { get; set; }
        public double Df1
        {
            get { return _points[0].Df; }
            set { _points[0].Df = value; }
        }
        public double Ddf1
        {
            get { return _points[0].Ddf; }
            set { _points[0].Ddf = value; }
        }
        public double Dfn
        {
            get { return _points[_points.Length - 1].Df; }
            set { _points[_points.Length - 1].Df = value; }
        }
        public double Ddfn
        {
            get { return _points[_points.Length - 1].Ddf; }
            set { _points[_points.Length - 1].Ddf = value; }
        }

        public CSpline(CPoint[] points)
        {
            _points = points;
            _splines = new CSplineSubinterval[points.Length - 1];
        }

        public void GenerateSplines(Color color)
        {
            const double x1 = 0;
            var y1 = BuildSplines(x1, color);
            const double x2 = 10;
            var y2 = BuildSplines(x2, color);

            _points[0].Ddf = -y1 * (x2 - x1) / (y2 - y1);

            BuildSplines(_points[0].Ddf, color);

            _points[_points.Length - 1].Ddf = _splines[_splines.Length - 1].Ddf(_points[_points.Length - 1].X);
        }

        private double BuildSplines(double ddf1, Color color)
        {
            double df = _points[0].Df, ddf = ddf1;
            for (var i = 0; i < _splines.Length; i++)
            {
                _splines[i] = new CSplineSubinterval(_points[i], _points[i + 1], df, ddf, color);

                df = _splines[i].Df(_points[i + 1].X);
                ddf = _splines[i].Ddf(_points[i + 1].X);

                if (i < _splines.Length - 1)
                {
                    _points[i + 1].Df = df;
                    _points[i + 1].Ddf = ddf;
                }
            }
            return df - Dfn;
        }

        public void Draw(Graphics canvas)
        {
            foreach (var spline in _splines)
            {
                spline.Draw(canvas);
            }
            foreach (var point in _points)
            {
                point.Draw(canvas);
            }
        }
    }
}
