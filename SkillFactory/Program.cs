using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            var name=Console.ReadLine();
            Console.Write("Enter your age: ");
          var age=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birthday:");
            var birthday=Console.ReadLine();
            Console.WriteLine("Yor birthday is {0}",birthday);
        } 
    }
}
