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
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.Write("Введите вид питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Введите возраст питомца: ");
            Pet.Age = double.Parse(Console.ReadLine());
        }

    }

}
    
    


