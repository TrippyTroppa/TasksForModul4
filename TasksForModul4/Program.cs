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
            int CurrentDay = 293;
            bool isLeapYear = false;

            bool isWinter = (!isLeapYear & (CurrentDay >= 335 | CurrentDay <= 59)) | (isLeapYear & (CurrentDay >= 336 | CurrentDay <= 60));
            Console.WriteLine($"Текущее время года зима: {isWinter}");
        }
    }
}
