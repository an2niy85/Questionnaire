using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            byte age;
            string zodiac;
            string work;

            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Какой ваш знак зодиака?");
            zodiac = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            work = Console.ReadLine();

            Console.WriteLine("Вас зовут " + name + ", вам " + age + " год, вы " + zodiac + " и работаете на " + work);
            Console.ReadLine();
        }
    }
}
