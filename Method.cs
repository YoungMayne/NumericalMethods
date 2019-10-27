using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods
{
    public class Method
    {
        public double x { set; get; }
        public double u1 { set; get; }
        public double u2 { set; get; }

        public double h { set; get; }
        public double eps { set; get; }

        public double[] k = new double[4];
        public double[] m = new double[4];

        public Functions functions = new Functions();

        private double TryStep(double _x, double _u1, double _u2, double _h, int _steps, bool save = false)
        {
            double curX = _x;
            double curU1 = _u1;
            double curU2 = _u2;
            while(_steps-- > 0)
            {
                k[0] = functions.f1(curX, curU1, curU2) * _h;
                m[0] = functions.f2(curX, curU1, curU2) * _h;
                k[1] = functions.f1(curX, curU1 + k[0] / 2.0, curU2 + m[0] / 2.0) * _h;
                m[1] = functions.f2(curX, curU1 + k[0] / 2.0, curU2 + m[0] / 2.0) * _h;
                k[2] = functions.f1(curX, curU1 + k[1] / 2.0, curU2 + m[1] / 2.0) * _h;
                m[2] = functions.f2(curX, curU1 + k[1] / 2.0, curU2 + m[1] / 2.0) * _h;
                k[3] = functions.f1(curX, curU1 + k[2], curU2 + m[2]) * _h;
                m[3] = functions.f2(curX, curU1 + k[2], curU2 + m[2]) * _h;

                curX += _h;
                curU1 += 1.0 / 6.0 * (k[0] + 2.0 * k[1] + 2.0 * k[2] + k[3]);
                curU2 += 1.0 / 6.0 * (m[0] + 2.0 * m[1] + 2.0 * m[2] + m[3]);
            }
            if (save)
            {
                x = curX;
                u1 = curU1;
                u2 = curU2;
            }
            return curU1;
        }

        public void OptimizationStep()
        {
            double u = TryStep(x,u1,u2,h,1);
            double _u = TryStep(x, u1, u2, h / 2.0, 2);
            while (Math.Abs(_u - u) > eps)
            {
                h /= 2;
                u = TryStep(x, u1, u2, h, 1);
                _u = TryStep(x, u1, u2, h / 2.0, 2);
            }
            while (Math.Abs(_u - u) < eps / 16.0)
            {
                h *= 2;
                u = TryStep(x, u1, u2, h, 1);
                _u = TryStep(x, u1, u2, h / 2.0, 2);
            }
        }

        public void Step()
        {
            TryStep(x, u1, u2, h, 1, true);
        }
    }
}
