using System.Security.Authentication.ExtendedProtection;
using Tortic;

namespace ConsoleApp3
{
    internal class Program
    {
        private static int cena = 0;
        static void Main()
        {

            category form = new category();
            form.form = new string[]
            {
                "Круг - ",
                "Квадрат - ",
                "Сердце - ",
                "Ромб - "
            };
            form.price = new int[]
                {300, 400, 500, 600};

            category decor = new category();
            decor.form = new string[]
            {
                "Шоколадный - ",
                "Ванильный - ",
                "Карамельный - "
            };
            decor.price = new int[]
                {150, 200,300 };

            category size = new category();
            size.form = new string[]
            {
                "Большой - ",
                "Маленький -",
                "Средний - "
            };
            size.price = new int[]
                {300, 150,200 };

            category kolvo = new category();

            kolvo.form = new string[]
            {
                "Один - ",
                "Два -",
                "Три - "
            };
            kolvo.price = new int[]
                {300, 350,450 };

            category[] categories = new category[] { form, decor, size, kolvo };
            vvod(categories);

        }
        static void vvod(category[] Two)
        {


            int b = 1;
            category name = new category(); ;
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Escape)
            {
                ConsoleKeyInfo clav = Console.ReadKey();
                

                while (clav.Key != ConsoleKey.Enter)
                {
                    if (clav.Key == ConsoleKey.UpArrow)
                    {
                        b--;
                    }
                    else if (clav.Key == ConsoleKey.DownArrow)
                    {
                        b++;
                    }
                    Console.Clear();


                    Console.WriteLine("Заказ тортиков в глазури");
                    Console.WriteLine("Выбирете параметры торта");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("  Форма тортика");
                    Console.WriteLine("  Декор Тортика");
                    Console.WriteLine("  Размер тортика");
                    Console.WriteLine("  Количество коржей в тортике");
                    Console.WriteLine("Цена: " + cena);
                    Console.WriteLine("  Конец заказа");

                    Console.SetCursorPosition(0, b);
                    Console.WriteLine("->");

                    clav = Console.ReadKey();

                    if (clav.Key == ConsoleKey.Escape)
                    {
                        File.AppendAllText("C:\\Users\\alang\\OneDrive\\Рабочий стол\\Заказы.txt", cena.ToString());
                        break;
                    }
                }
                int u = 0;
                clav = Console.ReadKey();
                while (clav.Key != ConsoleKey.Enter)
                {
                    if (clav.Key == ConsoleKey.UpArrow)
                    {
                        u--;
                    }
                    else if (clav.Key == ConsoleKey.DownArrow)
                    {
                        u++;
                    }
                    Console.Clear();


                    for (int i = 0; i < Two[b-3].price.Length; i++)
                    {
                        Console.Write("  " + Two[b-3].form[i]);
                        Console.WriteLine("  " + Two[b - 3].price[i]);

                    }
                    Console.SetCursorPosition(0, u);
                    Console.WriteLine("->");


                    clav = Console.ReadKey();
                }
                cena += Two[b-3].price[u];
            }
            
        }

    }
}
