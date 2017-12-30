using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class PrintCustom
    {
        public static void PrintUseColor(string color, string str)
        {
            switch (color.ToLower())
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
            }

        }
    }
}
