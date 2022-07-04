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
            Console.WriteLine("Welcome to # Programming Language! Enter your code here.\n");
            while (true)
            {
                string s = Console.ReadLine();
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            Console.WriteLine(strings[Convert.ToInt32(s.Substring(9))]);
                        }
                        else
                        {
                            Console.WriteLine(sections[1]);
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        Console.WriteLine("String " + num.ToString() + " is now " + strings[num]);
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
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
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            Console.WriteLine(strings[Convert.ToInt32(s.Substring(9))]);
                        }
                        else
                        {
                            Console.WriteLine(sections[1]);
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        Console.WriteLine("String " + num.ToString() + " is now " + strings[num]);
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
                }
            }
        }

        else if (args[0] == "-wii")
        {
            Console.WriteLine("Drag your folder in and press enter.");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(path + @"\load.shr");
            StreamWriter sw = File.CreateText(path + @"\main.lua");
            sw.WriteLine("function love.load");
            foreach (string s in lines)
            {
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            sw.WriteLine("love.graphics.print(" + strings[Convert.ToInt32(s.Substring(9))] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        else
                        {
                            sw.WriteLine("love.graphics.print(" + sections[1] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
                }
            }
            sw.WriteLine("end");

            lines = File.ReadAllLines(path + @"\update.shr");
            sw.WriteLine("function love.update");
            foreach (string s in lines)
            {
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            sw.WriteLine("love.graphics.print(" + strings[Convert.ToInt32(s.Substring(9))] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        else
                        {
                            sw.WriteLine("love.graphics.print(" + sections[1] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
                }
            }
            sw.WriteLine("end");

            lines = File.ReadAllLines(path + @"\draw.shr");
            sw.WriteLine("function love.draw");
            foreach (string s in lines)
            {
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            sw.WriteLine(@"love.graphics.print(""" + strings[Convert.ToInt32(s.Substring(9))] + @"""" + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        else
                        {
                            sw.WriteLine(@"love.graphics.print(""" + sections[1] + @"""" + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
                }
            }
            sw.WriteLine("end");
            sw.Flush();
            sw.Close();
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        else if (args[0] == "-lovr")
        {
            Console.WriteLine("Drag your folder in and press enter.");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(path + @"\load.shr");
            StreamWriter sw = File.CreateText(path + @"\main.lua");
            sw.WriteLine("function lovr.load");
            foreach (string s in lines)
            {
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            sw.WriteLine("lovr.graphics.print(" + strings[Convert.ToInt32(s.Substring(9))] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        else
                        {
                            sw.WriteLine("lovr.graphics.print(" + sections[1] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
                    case "3d_model":
                        sw.WriteLine(sections[1] + " = lovr.graphics.newModel('" + sections[2] + "')");
                        break;
                }
            }
            sw.WriteLine("end");

            lines = File.ReadAllLines(path + @"\update.shr");
            sw.WriteLine("function love.update");
            foreach (string s in lines)
            {
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            sw.WriteLine("lovr.graphics.print(" + strings[Convert.ToInt32(s.Substring(9))] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        else
                        {
                            sw.WriteLine("lovr.graphics.print(" + sections[1] + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
                    case "3d_model":
                        sw.WriteLine(sections[1] + " = lovr.graphics.newModel('" + sections[2] + "')");
                        break;
                }
            }
            sw.WriteLine("end");

            lines = File.ReadAllLines(path + @"\draw.shr");
            sw.WriteLine("function love.draw");
            foreach (string s in lines)
            {
                var sections = s.Split(' ');
                switch (sections[0])
                {
                    case "write":
                        if (sections[1].StartsWith("TXT"))
                        {
                            sw.WriteLine(@"lovr.graphics.print(""" + strings[Convert.ToInt32(s.Substring(9))] + @"""" + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        else
                        {
                            sw.WriteLine(@"lovr.graphics.print(""" + sections[1] + @"""" + ", 0, 0, 0, 0, 0, 0, 0)");
                        }
                        break;
                    case "text":
                        strings[num] = sections[1];
                        break;
                    case "rect":
                        // rect [color] [x] [y] [w] [h]
                        break;
                    case "circle":
                        // draw a circle
                        break;
                    case "3d_model":
                        sw.WriteLine(sections[1] + " = lovr.graphics.newModel('" + sections[2] + "')");
                        break;
                    case "draw_model":
                        sw.WriteLine(sections[1] + ":draw(" + sections[2] + ", " + sections[3] + ", " + sections[4] + ", " + sections[5] + ", " + sections[5] + ")");
                        break;
                }
            }
            sw.WriteLine("end");
            sw.Flush();
            sw.Close();
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
