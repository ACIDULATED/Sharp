using System;

class Program
{
    public static void Main(string[] args)
    {
        String[] strings = new string[999];
        int num = 0;
        Console.WriteLine("Welcome to Lazy#! Enter your code here.\n");
        while (true)
        {
            string s = Console.ReadLine();
            if (s.StartsWith("write "))
            {
               if (s.Substring(6).StartsWith("TXT")) {
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
