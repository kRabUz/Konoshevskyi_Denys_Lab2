using System;
using GoodsType;
using System.IO;

namespace Laba2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AllGoods good1 = new AllGoods();
            AllGoods good2 = new AllGoods();
            AllGoods good3 = new AllGoods();
            AllGoods good4 = new AllGoods();
            AllGoods good5 = new AllGoods();
            AllGoods good6 = new AllGoods();
            string[] buff = null;
            using (StreamReader sr = new StreamReader(@"C:\Education\ОП\Laba_2\Laba 2_2\laba.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                buff = line.Split(" ");
                }
            }
            good1.Input(0, buff);
            good2.Input(1, buff);
            good3.Input(2, buff);
            good4.Input(3, buff);
            good5.Input(4, buff);
            good6.Input(5, buff);
            Goods.Sort(good1, good2, good3, good4, good5, good6);
            Console.WriteLine("Введiть мiнiмальну цiну дiапазона");
            int min=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть максимальну цiну дiапазона");
            int max = Convert.ToInt32(Console.ReadLine());
            Goods.InDiapasone(min, max, good1, good2, good3, good4, good5, good6);
            Console.WriteLine("Введiть сьогоднiшню дату");
            DateTime today = Convert.ToDateTime(Console.ReadLine());
            Goods.Dates(today, good1, good2, good3, good4, good5, good6);
        }
    }
}
