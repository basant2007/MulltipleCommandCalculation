using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "add 1,4,5";

            ICalc cal = null;
            string result = null;
            
            CalcFactory cf = new CalcFactory();

            cal = cf.GetObject("add1"); //Wrong command
            //cal = cf.GetObject(cmd.Substring(0,cmd.Split(' ')[0].Length)); //correct command
            if (cal != null)
            {
                Console.WriteLine("No command found");
                result = cal.Calculation(command);
                Console.WriteLine($"output of add command is {result}");
            }

            cal = cf.GetObject(command.Substring(0, command.Split(' ')[0].Length));
            if (cal != null)
            {
                Console.WriteLine("No command found");
                result = cal.Calculation(command);
                Console.WriteLine($"output of add command is {result}");
            }
            

            Console.Read();
        }

        
    }
}
