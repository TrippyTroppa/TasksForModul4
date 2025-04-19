using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyApple = 5;
            var HisPears = 5;
            var HisApples = 6;

            var result = (MyApple != HisApples) & (MyApple == HisPears);
            Console.WriteLine(result);
        }
    }
}
