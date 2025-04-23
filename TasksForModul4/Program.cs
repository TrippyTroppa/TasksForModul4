using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arrray = new int [] {-1,2,-3,4,-5,6,-7,-8,9};
            var num = 0;

            for (int i = 0; i < arrray.Length; i++)
            {
                if (arrray[i] > 0)
                    num++;
            }
            Console.WriteLine(num);
        }
    }
}

