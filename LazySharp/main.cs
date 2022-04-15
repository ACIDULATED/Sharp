using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        String[] strings = new string[999];
        int num = 0;
        if (args[0] == "-s")
        {
            Console.WriteLine("Welcome to Lazy#! Enter your code here.\n");
            while (true)
            {
                string s = Console.ReadLine();
                if (s.StartsWith("write "))
                {
                    if (s.Substring(6).StartsWith("TXT"))
                    {
                        Console.WriteLine(strings[Convert.ToInt32(s.Substring(9))]);
                    }
                }
                else if (s.StartsWith("text "))
                {
                    strings[num] = s.Substring(5);
                    Console.WriteLine("String " + num.ToString() + " is now " + strings[num]);
                }
            }
        }
        else if (args[0] == "-o")
        {
            Console.WriteLine("Drag your file in and press enter.");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(path);
            foreach (string s in lines)
            {
                if (s.StartsWith("write "))
                {
                    if (s.Substring(6).StartsWith("TXT"))
                    {
                        Console.WriteLine(strings[Convert.ToInt32(s.Substring(9))]);
                    }
                }
                else if (s.StartsWith("text "))
                {
                    strings[num] = s.Substring(5);
                    Console.WriteLine("String " + num.ToString() + " is now " + strings[num]);
                }
            }
        }
    }
}
