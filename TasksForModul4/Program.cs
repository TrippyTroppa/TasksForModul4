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

            Console.Write("Ваше имя по буквам: ");
            foreach (char letter in name) 
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine("Последняя буква имени: " + name[name.Length - 1]);

        }
    }
}

