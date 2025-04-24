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
            var anketa = (name: "Jane", age: 27);

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

        }
    
    }
}

