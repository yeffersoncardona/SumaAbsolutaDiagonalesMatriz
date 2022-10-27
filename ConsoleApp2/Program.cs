using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        public static int diagonalDifference(List<List<int>> arr, int n)
        {
            //Math.Abs(value)
            int sumdiag1 = 0;
            int sumdiag2 = 0;
            int AbsoluteValue = 0;
            for (int i = 0; i < n; i++)
            {
                sumdiag1 = arr[i][i] + sumdiag1;
               

            }
            for (int c = 0, k = n - 1; c < n ; c++, k--)
            {
                sumdiag2 = arr[c][k] + sumdiag2;
              
            }
            int resta = sumdiag1 - sumdiag2;    
            AbsoluteValue = Math.Abs(resta);
            return AbsoluteValue;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("miprueba", true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr, n);

            Console.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
