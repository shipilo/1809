using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_1809
{
    class Program
    {
        public enum Mounths : int
        {
            Январь,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            /*
            Console.WriteLine("A1.1");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("а) Полных часов прошло: {0}", seconds / 3600);
            Console.WriteLine("б) Полных минут прошло: {0}", seconds / 60);
            Console.WriteLine("в) Полных секунд с начала минуты прошло: {0}", seconds % 60);

            Console.WriteLine("\nA1.2");
            int side1 = 543, side2 = 130;
            Console.WriteLine((side1 / 130) * (side2 / 130));
            
            Console.WriteLine("\nA1.3");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 12) Console.WriteLine("Январь");
            else Console.WriteLine((Mounths)n);
            */
            Console.WriteLine("\nA1.4");
            int num = rnd.Next(10, 100);
            Console.WriteLine("Число = {0}", num);
            Console.WriteLine("Число десятков = {0}", num / 10);
            Console.WriteLine("Число единиц = {0}", num % 10);
            Console.WriteLine("Сумма цифр = {0}", num / 10 + num % 10);
            Console.WriteLine("Произведение цифр = {0}", num / 10 * (num % 10));


            Console.ReadLine();
        }
    }
}
