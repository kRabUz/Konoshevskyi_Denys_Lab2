using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba2_2
{
    abstract class Goods
    {
        public string type;
        public string name;
        public int price;
        public DateTime start;
        public DateTime end;
        public Goods()
        {
            type = "unknown";
            name = "unknown";
            price = 100;
            start = DateTime.MinValue;
            end = DateTime.MaxValue;
        }
        public Goods(string type, string name, int price, DateTime start, DateTime end)
        {
            this.type = type;
            this.name = name;
            this.price = price;
            this.start = start;
            this.end = end;
        }
        public void Input(int num, string[] buff)
        {
                    Console.WriteLine("Введiть тип продукту(Milk,Fruit,Vegetable): ");
                    Console.WriteLine(buff[0 + num * 5]);
                    type = buff[0 + num * 5];
                    Console.WriteLine("Введiть назву продукту: ");
                    Console.WriteLine(buff[1 + num * 5]);
                    name = buff[1 + num * 5];
                    Console.WriteLine("Введiть вартiсть продукту: ");
                    Console.WriteLine(buff[2 + num * 5]);
                    price = Convert.ToInt32(buff[2 + num * 5]);
                    Console.WriteLine("Введiть дату виготовлення: ");
                    Console.WriteLine(buff[3 + num * 5]);
                    start = Convert.ToDateTime(buff[3 + num * 5]);
                    Console.WriteLine("Введiть дату кiнця термiну придатностi: ");
                    Console.WriteLine(buff[4 + num * 5]);
                    end = Convert.ToDateTime(buff[4 + num * 5]);
        }
        public static void Sort(params Goods[] arr)
        {
            int len = arr.Length;
            int m = 0, f = 0, v = 0;
            for (int i = 0; i < len; ++i)
            {
                if (arr[i].type == "Milk") ++m;
                if (arr[i].type == "Fruit") ++f;
                if (arr[i].type == "Vegetable") ++v;
            }
            for (int i = 1; i < len; ++i)
            {
                for (int j = 0; j < len - i; ++j)
                {
                    if (arr[j].type != "Milk" && arr[j+1].type == "Milk")
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            for (int i = 1; i < len; ++i)
            {
                for (int j = 0; j < len - i; ++j)
                {
                    if (arr[j].type == "Vegetable" && arr[j + 1].type != "Vegetable")
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j < m - i; j++)
                {
                    if (arr[j].price > arr[j + 1].price)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            for (int i = 1; i < f; ++i)
            {
                for (int j = m; j < m + f - i; ++j)
                {
                    if (arr[j].price > arr[j + 1].price)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            for (int i = 1; i < v; ++i)
            {
                for (int j = m + f; j < len - i; ++j)
                {
                    if (arr[j].price > arr[j + 1].price)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            Console.WriteLine("Продукти, сортованi за типом i вартiстю:");
            for (int i = 0; i < len; ++i)
            {
                Console.WriteLine($"{arr[i].type} : {arr[i].name} : {arr[i].price} грн");
            }
        }
        private static void Swap(ref Goods ex1, ref Goods ex2)
        {
            Goods temp = ex1;
            ex1 = ex2;
            ex2 = temp;
        }
        public static void InDiapasone(int min, int max, params Goods[] arr)
        {
            Console.WriteLine($"Продукти в дiапазонi вiд {min} до {max} грн:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].price >= min && arr[i].price <= max)
                {
                    Console.WriteLine($"{arr[i].name} з вартiстю {arr[i].price} грн");
                }
            }
        }
        public static void Dates(DateTime today, params Goods[] arr)
        {
            Console.WriteLine($"Простроченi продукти:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (today>arr[i].end)
                {
                    Console.WriteLine($"Продукт {arr[i].name} прострочений");
                }
            }
            DateTime compare1 = new DateTime(2019,12,31);
            DateTime compare2 = new DateTime(2020, 2, 1);
            Console.WriteLine($"Продукти, виготовленi у сiчнi 2020:");
            for (int i = 0; i < arr.Length; i++)
            {
                if ( compare2 > arr[i].start && compare1 < arr[i].start)
                {
                    Console.WriteLine($"Продукт {arr[i].name}");
                }
            }
        }
    }
}
