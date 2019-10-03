using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Drawing
    {
        public static void DrawX2(int n , char c ='*')
        {
            // cArr[i,j]; i 
            char[,] cArr = new char[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    cArr[i, j] = ' ';

            for (int i = 0; i < n;i++ )
            {
                cArr[i, i] = c;
            }
            for (int i = 0; i < n; i++)
            {
                cArr[i, n - 1 - i] = c;
            }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(cArr[i, j]);
                    Console.WriteLine();
                }

        }
    }
}
