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
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваше имя в обратном порядке: ");

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }

        }
    }
}

