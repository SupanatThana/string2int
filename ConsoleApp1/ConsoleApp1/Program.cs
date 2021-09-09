using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string output = string.Empty;
            try
            {
                Console.Write("Input String : ");
                string input = Console.ReadLine();

                foreach (char c in input)
                {
                    if (Char.IsNumber(c))
                    {
                        sb.Append(c);
                    }
                }
                output = sb.ToString();

                //2nd Method
                //output = Regex.Replace(input, "[^0-9.]", "");

                //3rd Method (Remove letter from input)
                //int index = 0;
                //foreach (char c in input)
                //{
                //    if (Char.IsLetter(c))
                //    {
                //        input = input.Remove(index, 1);
                //    }
                //    else
                //    {
                //        index++;
                //    }
                //}
                //output = input;

                Console.WriteLine($"Output String : {output}");

                Console.ReadKey();
            }
            catch
            {
                throw;
            }
            
        }
    }

   
}
