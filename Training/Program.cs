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


namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);

        }

        public static void plusMinus(List<int> arr)
        {
            double positiveNumbers = 0, negativeNumbers = 0, zeroNumbers = 0;

            
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                    positiveNumbers++;
                else if (arr[i] < 0)
                    negativeNumbers++;
                else
                    zeroNumbers++;
            }

            Console.WriteLine(positiveNumbers / arr.Count);
            Console.WriteLine(negativeNumbers / arr.Count);
            Console.WriteLine(zeroNumbers / arr.Count);



        }

    }
}
