using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2_2;

namespace GoodsType
{
    class AllGoods : Goods
    {
        public AllGoods() : base() { }
        public AllGoods(string type, string name, int price, DateTime start, DateTime end) : base(type, name, price, start, end) { }

    }
}