using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_1809
{
    class Program
    {
        enum Mounths : int
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
            int n, a1, b1, a2, b2, k, seconds, side1, side2, side_sqr, flower1, flower2;
            float time, litres = 0.5F;
            bool a, b, c, x, y, z;
            
            Console.WriteLine("A1.1");
            seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("а) Полных часов прошло: {0}", seconds / 3600);
            Console.WriteLine("б) Полных минут с начала часа прошло: {0}", seconds % 3600 / 60);
            Console.WriteLine("в) Полных секунд с начала минуты прошло: {0}", seconds % 60);

            Console.WriteLine("\nA1.2");
            side1 = 543;
            side2 = 130;
            side_sqr = 130;
            Console.WriteLine((side1 / side_sqr) * (side2 / side_sqr));
            
            Console.WriteLine("\nA1.3");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 12) Console.WriteLine("Январь");
            else Console.WriteLine((Mounths)n);
            
            Console.WriteLine("\nA1.4");
            n = rnd.Next(10, 100);
            Console.WriteLine("Число = {0}", n);
            Console.WriteLine("Число десятков = {0}", n / 10);
            Console.WriteLine("Число единиц = {0}", n % 10);
            Console.WriteLine("Сумма цифр = {0}", n / 10 + n % 10);
            Console.WriteLine("Произведение цифр = {0}", n / 10 * (n % 10));
            
            Console.WriteLine("\nA1.5");
            n = rnd.Next(100, 1000);
            Console.WriteLine($"{n} -> {n % 100 * 10 + n / 100}");
            
            Console.WriteLine("\nA1.6");
            n = 237;
            Console.WriteLine($"x = {n % 100 * 10 + n / 100}");
            
            Console.WriteLine("\nA1.7");
            a2 = Convert.ToInt32(Console.ReadLine());
            a1 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a2a1 + b2b1 = {a2 + b2 + (a1 + b1) / 10}{(a1 + b1) % 10}");
            
            Console.WriteLine("\nA1.8");
            Console.Write("k, кратное трём: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((k / 3));
            Console.WriteLine($"k-ая цифра = {(k / 3) % 10}");

            Console.Write("\nk = 1, 4, 7, ... : ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"k-ая цифра = 1");

            Console.Write("\nk = 2, 5, 8, ... : ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"k-ая цифра = {(k + 2) / 30}");
            
            Console.WriteLine("\nA1.9");
            a = true;
            b = false;
            c = false;
            Console.WriteLine($"а) А или B = {ConvertToRussian(a || b)}");
            Console.WriteLine($"б) А и B = {ConvertToRussian(a && b)}");
            Console.WriteLine($"а) B или C = {ConvertToRussian(b || c)}");
            
            Console.WriteLine("\nA1.10");
            x = false;
            y = false;
            z = false;
            Console.WriteLine("\nX Y Z: не (X или Y) и (не X или не Z)");
            Console.Write($"{Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} ");
            Console.Write(ConvertToRussian(!(x || y) && (!x || !z)) + "\n");
            while (!(x && y && z))
            {
                if (!z) z = true;
                else
                {
                    z = false;
                    if (!y) y = true;
                    else
                    {
                        y = false;
                        if (!x) x = true;
                    }
                }
                Console.Write($"{Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} ");
                Console.Write(ConvertToRussian(!(x || y) && (!x || !z)) + "\n");                
            }
            x = false;
            y = false;
            z = false;
            Console.WriteLine("\nX Y Z: не (не X и Y) или (X и не Z)");
            Console.Write($"{Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} ");
            Console.Write(ConvertToRussian(!(!x && y) || (x && !z)) + "\n");
            while (!(x && y && z))
            {
                if (!z) z = true;
                else
                {
                    z = false;
                    if (!y) y = true;
                    else
                    {
                        y = false;
                        if (!x) x = true;
                    }
                }
                Console.Write($"{Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} ");
                Console.Write(ConvertToRussian(!(!x && y) || (x && !z)) + "\n");                
            }
            x = false;
            y = false;
            z = false;
            Console.WriteLine("\nX Y Z: X или не Y и не (X или не Z)");
            Console.Write($"{Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} ");
            Console.Write(ConvertToRussian(x || !y && !(x || !z)) + "\n");
            while (!(x && y && z))
            {
                if (!z) z = true;
                else
                {
                    z = false;
                    if (!y) y = true;
                    else
                    {
                        y = false;
                        if (!x) x = true;
                    }
                }
                Console.Write($"{Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} ");
                Console.Write(ConvertToRussian(x || !y && !(x || !z)) + "\n");                
            }
            
            Console.WriteLine("\nДоп. 1");
            flower1 = Convert.ToInt32(Console.ReadLine());
            flower2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsLoving(flower1, flower2));
            
            Console.WriteLine("\nДоп. 2");
            Console.Write("Time = ");
            time = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Liters = {Math.Floor(time * litres)}");

            Console.ReadLine();
        }
        static string ConvertToRussian(bool logical)
        {
            if (logical) return "Истина";
            else return "Ложь";
        }
        static bool IsLoving(int flower1, int flower2)
        {
            if (flower1 % 2 == 0 && flower2 % 2 == 1 || flower1 % 2 == 1 && flower2 % 2 == 0)
                return true;
            else return false;
        }
    }
}
