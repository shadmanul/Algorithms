using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgo
{
    class Program
    {
        static string[] p = new string[4]{"01101","11000","01000","10011"};
        static double[] f = new double[4]{0,0,0,0};
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("\n--POPULATION--\n");
            for (int i = 0; i < 4; i++)
                Console.WriteLine("P[" + i + "] - " + p[i]);
            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine("\n--GENERATION["+(j+1)+"]--\n");
                Console.WriteLine("\n--F(X)=X^2--\n");
                for (int i = 0; i < 4; i++)
                {
                    f[i] = Math.Pow(Convert.ToInt32(p[i], 2), 2);
                    Console.WriteLine("F[" + i + "] - " + f[i]);
                }
                CrossOver(p[0], p[1]);
                CrossOverSecond(p[2], p[3]);
                Console.WriteLine("\n--CROSSOVER--\n");
                for (int i = 0; i < 4; i++)
                    Console.WriteLine("P[" + i + "] - " + p[i]);
                Mutation();
                for (int i = 0; i < 4; i++)
                {
                    if (f[i] > 900)
                        c = 1;
                }
                if (c == 1)
                {
                    break;
                }
                Array.Sort<string>(p);
                Array.Reverse(p);
                
            }
        }

        private static void Mutation()
        {
            char[] a = new char[5];
            char[] b = new char[5];
            char[] c = new char[5];
            char[] d = new char[5];

            a = p[0].ToCharArray();
            b = p[1].ToCharArray();
            c = p[2].ToCharArray();
            d = p[3].ToCharArray();
            Random rnd = new Random();
            int k = 0;
            k = rnd.Next(0,4);
            if (a[k] == '1')
                a[k] = '0';
            else
                a[k] = '1';
            k = rnd.Next(0, 4);
            if (b[k] == '1')
                b[k] = '0';
            else
                b[k] = '1';
            k = rnd.Next(0, 4);
            if (c[k] == '1')
                c[k] = '0';
            else
                c[k] = '1';
            k = rnd.Next(0, 4);
            if (d[k] == '1')
                d[k] = '0';
            else
                d[k] = '1';

            p[0] = p[1] = p[2] = p[3] = "";
            for (int i = 0; i < 5; i++)
            {
                p[0] += a[i];
            }
            for (int i = 0; i < 5; i++)
            {
                p[1] += b[i];
            }
            for (int i = 0; i < 5; i++)
            {
                p[2] += c[i];
            }
            for (int i = 0; i < 5; i++)
            {
                p[3] += d[i];
            }
            Console.WriteLine("\n--MUTATION--\n");
            for (int i = 0; i < 4; i++ )
                Console.WriteLine("P["+i+"] - "+p[i]);
        }

        private static void CrossOverSecond(string p1, string p2)
        {
            char[] temp = new char[5];
            char[] x = new char[5];
            x = p1.ToCharArray();

            char[] y = new char[5];
            y = p2.ToCharArray();
            int h = 0;
            Random rnd = new Random();
            h = rnd.Next(0, 3);
            for (int i = h; i < 5; i++)
            {
                temp[i - h] = x[i];
            }
            for (int i = h; i < 5; i++)
            {
                x[i] = y[i];
                y[i] = temp[i - h];
            }
            p[2] = p[3] = "";
            for (int i = 0; i < 5; i++)
            {
                p[2] += x[i];
            }
            for (int i = 0; i < 5; i++)
            {
                p[3] += y[i];
            }
        }

        private static void CrossOver(string p1, string p2)
        {
            char[] temp = new char[5];
            char[] x = new char[5];
            x = p1.ToCharArray();

            char[] y = new char[5];
            y = p2.ToCharArray();
            int h = 0;
            Random rnd = new Random();
            h = rnd.Next(0, 3);
            for (int i = h; i < 5; i++)
            {
                temp[i-h] = x[i];
            }
            for (int i = h; i < 5; i++)
            {
                x[i] = y[i];
                y[i] = temp[i - h];
            }
            p[0] = p[1] = "";
            for (int i = 0; i < 5; i++)
            {
                p[0] += x[i];
            }
            for (int i = 0; i < 5; i++)
            {
                p[1] += y[i];
            }
            
        }
    }
}
