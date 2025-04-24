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
            (string name, int age) anketa;

            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ваше имя: {anketa.name}\nВаш возраст: {anketa.age}");

        }
    
    }
}

