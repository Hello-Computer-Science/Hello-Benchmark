using Test.CSharp.Algorithms;
using System;
using System.Text;

namespace Test.CSharp;

public static class Program
{
    public static void Main(string[] args)
    {
        var datafile = Path.GetFullPath(args[0]);

        #region Sort

        var array = File.ReadAllLines(datafile)
                        .ToIntArray()
                        // .PrintArray("Source array: ")
                        ;
        Console.WriteLine("Reading done!");
        ((int[])array).ToList().Sort();
        // BubbleSort.Sort((int[])array);
        // array.PrintArray("Sorted array: ");
        Console.WriteLine("Sort done!");

        #endregion
    }

    public static int[] ToIntArray(this string[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; ++i)
            result[i] = int.Parse(array[i]);
        return result;
    }

    public static IList<T> PrintArray<T>(this IList<T> array, string tip = "")
    {
        StringBuilder sb = new();
        sb.Append(tip);
        foreach (var item in array) sb.Append(item.ToString()).Append(' ');
        Console.WriteLine(sb.ToString());
        return array;
    }
}


