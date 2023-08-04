using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
           int testCases = int.Parse(Console.ReadLine());
        for (int cs = 1; cs <= testCases; cs++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(input[i]);
            }
            FindZigZagSequence(a, n);
        }

    }
     public static void FindZigZagSequence(int[] a, int n)
    {
        Array.Sort(a);
        int mid = (n - 1) / 2;
        int temp = a[mid];
        a[mid] = a[n - 1];
        a[n - 1] = temp;

        int st = mid + 1;
        int ed = n - 2;
        while (st <= ed)
        {
            temp = a[st];
            a[st] = a[ed];
            a[ed] = temp;
            st = st + 1;
            ed = ed - 1;
        }
        for (int i = 0; i < n; i++)
        {
            if (i > 0) Console.Write(" ");
            Console.Write(a[i]);
        }
        Console.WriteLine();
    }
}


// this was kinda glitching a lot - the site would show the programs ooutput as the expected output but still say it was wrong. I'm moving on. 
