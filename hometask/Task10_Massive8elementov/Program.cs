using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[8];
        Random rnd = new Random();

        for(int i=0; i<arr.Length; i++)
        {
            arr[i] = rnd.Next();
            Console.Write(arr[i]);
            if(i != arr.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("");
    }
}