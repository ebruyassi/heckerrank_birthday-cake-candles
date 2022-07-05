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
    public static int birthdayCakeCandles(List<int> candles)
    {
        candles.Sort();
        candles.Reverse();
        
        int count=0;
        
        for(int i=0;i<candles.Count;i++){
            if(candles[i]==candles[0])
              count++;
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        
         Console.WriteLine("sort");
         candles.Sort();
        foreach(var item in candles)
           Console.WriteLine(item);
        Console.WriteLine("reverse");
         candles.Reverse();
        foreach(var item2 in candles)
           Console.WriteLine(item2);
    }
}
