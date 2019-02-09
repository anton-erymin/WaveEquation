using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaveEquation
{
    class Matrix
    {
        public static double[] solve(double[] a, double[] b, double[] c, double[] d)
        {
            int n = a.Length;

            double[] P = new double[n];
            double[] Q = new double[n];
            double[] x = new double[n];

            P[0] = -b[0] / a[0];
            Q[0] = d[0] / a[0];

            for (int i = 1; i < n; i++)
            {
                P[i] = -b[i] / (c[i] * P[i - 1] + a[i]);
                Q[i] = (d[i] - c[i] * Q[i - 1]) / (c[i] * P[i - 1] + a[i]);
            }

            x[n - 1] = Q[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                x[i] = P[i] * x[i + 1] + Q[i];
            }

            return x;
        }
    }
}