using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WaveEquation
{
    public partial class Form1 : Form
    {
        double[,] u;
        double[] x;
        double[] t;

        double x0 = -10;
        double xn = 10;

        int numx;
        int numt;

        double t0;
        double tn;

        double dx;
        double dt;
        double r;
        double k1;
        double k2;
        double sigma;
        double a2;

        int pause;

        public Form1()
        {
            InitializeComponent();

        }

        void solve()
        {
            t0 = Double.Parse(txtT0.Text);
            tn = Double.Parse(txtTn.Text);
            numx = Int32.Parse(txtNumx.Text);
            numt = Int32.Parse(txtNumt.Text);

            dx = (xn - x0) / numx;
            dt = (tn - t0) / numt;

            a2 = Double.Parse(txtA2.Text);
            sigma = Double.Parse(txtSigma.Text);
            pause = Int32.Parse(txtPause.Text);

            r = (dx * dx) / (dt * dt);
            k1 = a2 * a2 * sigma;
            k2 = a2 * a2 * (1 - sigma);


            u = new double[numx + 1, numt + 1];
            x = new double[numx + 1];
            t = new double[numt + 1];

            for (int i = 0; i < numx + 1; i++)
                for (int j = 0; j < numt + 1; j++)
                {
                    u[i, j] = 0;
                }

            for (int i = 0; i < numx + 1; i++)
            {
                x[i] = x0 + i * dx;
            }

            for (int i = 0; i < numt + 1; i++)
            {
                t[i] = t0 + i * dt;
            }


            //for (int i = 0; i < numx + 1; i++)
            //{
            //    u[i, 0] = Math.Sin((1 / 1) * x[i]);
            //    u[i, 1] = Math.Sin((1 / 1) * x[i]);
            //}

            //for (int i = 0; i < numt + 1; i++)
            //{
            //    u[0, i] = 4 * Math.Sin((1 / 1) * t[i]);
            //}

            for (int i = 40, j = 0; i < 50; i++, j++)
            {
                u[i, 0] = (double)j / 4;
                u[i, 1] = (double)j / 4;
            }

            for (int i = 49, j = 9; i < 59; i++, j--)
            {
                u[i, 0] = (double)j / 4;
                u[i, 1] = (double)j / 4;
            }


            double[] a = new double[numx + 1];
            double[] b = new double[numx + 1];
            double[] c = new double[numx + 1];
            double[] d = new double[numx + 1];


            for (int i = 1; i < numx; i++)
            {
                a[i] = r + 2 * k1;
                b[i] = -k1;
                c[i] = -k1;
            }

            c[0] = 0;
            b[numx] = 0;
            a[0] = 1;
            a[numx] = 1;


            for (int j = 1; j < numt; j++)
            {
                for (int i = 1; i < numx; i++)
                {
                    d[i] = k2 * u[i + 1, j] + (2 * r - 2 * k2) * u[i, j] + k2 * u[i - 1, j] - r * u[i, j - 1];
                }
                d[0] += u[0, j + 1];
                d[numx] += u[numx, j + 1];

                double[] w = Matrix.solve(a, b, c, d);

                for (int i = 1; i < numx; i++)
                {
                    u[i, j + 1] = w[i - 1];
                }
            }
        }

        void render()
        {
            int basex = this.Width / 2;
            int basey = this.Height / 2;

            int scalex = this.Width / 24;
            int scaley = this.Height / 12;

            Graphics gr = Graphics.FromHwnd(Handle);

            Point[] p = new Point[numx + 1];

            for (int j = 0; j < numt + 1; j++)
            {
                for (int i = 0; i < numx + 1; i++)
                {
                    p[i] = new Point((int)(basex + scalex * x[i]), (int)(basey - scaley * u[i, j]));
                }

                
                gr.DrawLines(new Pen(Color.Green, 2.0f), p);
                Thread.Sleep(pause);
                gr.DrawLines(new Pen(Color.White, 2.0f), p);
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            solve();
            render();
        }

    }


}
