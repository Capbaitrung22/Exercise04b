﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsContain5or6(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5 || iArr[i] == 6)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsContain5and6(int[] iArr)
        {
            bool foundsix = false;
            bool foundfive = false;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                {
                    foundfive = true;

                }

            }
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 6)
                {
                    foundsix = true;
                }
            }
            if (foundfive == true && foundsix == true)
            {


                return true;
            }

            return false;
        }
        public static int Count5(int[] iArr)
        {
            int c = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                    c++;
            }

            return c;

        }
        public static int Count5or6(int[] Arr)
        {
            int count = 0;
            for (int i = 0;i < Arr.Length ; i++)
            {
                if(Arr[i] == 5 || Arr[i] == 6);
                
            }

            return count;
        }
        public static int Sum(int[] iArr)
        {
            int result = 0;
            for (int i = 0; i < iArr.Length;i++ )
            {
            return += iArr[i];
        }
        return result;    
        
    }

}
