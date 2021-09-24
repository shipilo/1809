using System;

namespace Les_1809
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            
            //1
            Console.WriteLine($"Byte - {Byte.MinValue} - {Byte.MaxValue}");
            Console.WriteLine($"SByte - {SByte.MinValue} - {SByte.MaxValue}");
            Console.WriteLine($"Short - {Int16.MinValue} - {Int16.MaxValue}");
            Console.WriteLine($"UShort - {UInt16.MinValue} - {UInt16.MaxValue}");
            Console.WriteLine($"Int - {Int32.MinValue} - {Int32.MaxValue}");
            Console.WriteLine($"UInt - {UInt32.MinValue} - {UInt32.MaxValue}");
            Console.WriteLine($"Long - {Int64.MinValue} - {Int64.MaxValue}");
            Console.WriteLine($"ULong - {UInt64.MinValue} - {UInt64.MaxValue}");
            Console.WriteLine($"Float - {Single.MinValue} - {Single.MaxValue}");
            Console.WriteLine($"Double - {Double.MinValue} - {Double.MaxValue}");
            Console.WriteLine($"Decimal - {Decimal.MinValue} - {Decimal.MaxValue}");

            //2
            Console.WriteLine("\nДанные пользователя");
            string name = Console.ReadLine();
            string city = Console.ReadLine();
            short age = Convert.ToInt16(Console.ReadLine());
            short pin = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Имя: {name}\nГород: {city}\nВозраст: {age}\nPIN: {pin}\n");
            
            //3
            str = Console.ReadLine();
            char[] str_in = new char[str.Length];
            str_in = str.ToCharArray();
            char[] str_out = new char[str.Length];
            for(int i = 0; i < str_in.Length; i++)
            {
                if (char.IsLetter(str_in[i]))
                {
                    if (char.IsLower(str_in[i])) str_out[i] = char.ToUpper(str_in[i]);
                    else str_out[i] = char.ToLower(str_in[i]);
                }
                else str_out[i] = str_in[i];
            }
            Console.WriteLine(String.Join("", str_out) + "\n");
            
            //4
            str = Console.ReadLine();
            string str_sub = Console.ReadLine();
            int k = 0;
            while(true)
            {
                if (str.Contains(str_sub))
                {
                    int index = str.IndexOf(str_sub);
                    str = str.Substring(index + str_sub.Length);
                    k++;
                }
                else break;
            }
            Console.WriteLine("Подстрока встречается {0} раз(а)\n", k);

            //5
            Console.WriteLine(ToCMperSekonds(Convert.ToDouble(Console.ReadLine())) + "\n");
            
            //6
            Console.WriteLine(HowManyYears(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + "\n");
            
            //7
            int normPrice = Convert.ToInt32(Console.ReadLine());
            int salePrice = Convert.ToInt32(Console.ReadLine());
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Необходимо купить {Math.Floor(holidayPrice / ((double)normPrice * salePrice / 100))} бутылок(ку/ки)");
            Console.ReadLine();
        }

        static int ToCMperSekonds(double km_per_h)
        {
            return (int)Math.Floor(km_per_h * 100000 / 3600);
        }

        static string HowManyYears(int age_father, int age_son)
        {
            if (age_father > age_son * 2)
                return $"Через {age_father - 2 * age_son} лет(год/года) отец будет старше своего сына в 2 раза";
            else if (age_father == age_son * 2) return "На данный момент отец старше сына в 2 раза";
            else return $"{2 * age_son - age_father} лет(год/года) назад отец был старше своего сына в 2 раза";
        }
    }
}
