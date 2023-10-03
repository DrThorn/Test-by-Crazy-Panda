using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    class Program
    {
        static void Main(string[] args)
        {
            int start=0, end=0;
            List<uint> list = new List<uint>();
            Random rnd = new Random();
            for (int i = 0; i < 15000000; i++)
            {
                list.Add((uint)rnd.Next(0, 10000)); //fill the array with random numbers
            }
            Adder search = new Adder();
            search.FindElementsForSum(list, 7689147, out start,out end);
            Console.WriteLine("start= "+start);
            Console.WriteLine("end= "+end);
        }

        
    }

    class Adder
    {    

        public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            // your code here
            start = 0;
            end = 0;
            ulong _sum;
            for (int i=0; i < list.Count; i++)
            {
                _sum = 0;
                for (int j = i; j < list.Count; j++)
                {
                    _sum = _sum + list[j];
                    if (_sum == sum)
                    {
                        start = i;
                        end = j+1;
                        return;
                    }
                    if (_sum > sum)
                    {
                        break;
                    }
                }
               
            }
        }


    }
}
