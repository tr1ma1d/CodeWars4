using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var sheeps = new bool[] { true, false, true };
            int count = 0;
            for(int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true) {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
