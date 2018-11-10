using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            double x = 100;
            int greatestPow = 0;
            while(x >= 0) { 
                int counter = 0;
                while(Math.Pow(2, counter) <= x)
                {
                    counter++;
                }
                counter = counter - 1;
                if(counter >= greatestPow)
                {
                    greatestPow = counter;
                }
                list.Add(counter);
                x = x - Math.Pow(2, counter);
            }
            Console.WriteLine(GetBinary(list, greatestPow));
            Console.ReadLine();
        }
        public static string GetBinary(List<int> listOfPowers, int greatestPow)
        {
            string binary = "";
            while (greatestPow >= 0)
            {
                bool found = false;
                for (int i = 0; i < listOfPowers.Count; i++)
                {
                    if (listOfPowers[i] == greatestPow)
                    {
                        binary = binary + "1";
                        found = true;
                    }
                }
                if (!found)
                {
                    binary = binary + "0";
                }
                greatestPow--;
            }
            return binary;
        }
    }
}
