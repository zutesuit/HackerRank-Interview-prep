/* Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal. */

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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int total = arr.Count;
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        foreach (int num in arr)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
            else
                zeroCount++;
        }

        decimal positiveRatio = (decimal)positiveCount / total;
        decimal negativeRatio = (decimal)negativeCount / total;
        decimal zeroRatio = (decimal)zeroCount / total;

        Console.WriteLine(positiveRatio.ToString("0.000000"));
        Console.WriteLine(negativeRatio.ToString("0.000000"));
        Console.WriteLine(zeroRatio.ToString("0.000000"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
