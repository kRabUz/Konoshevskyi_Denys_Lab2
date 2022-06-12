using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_1
{
    class Satellite
    {
        private int amount;
        public int Amount { get { return amount; } set { amount = value; } }
        public Satellite(int amount)
        {
            this.amount = amount;
        }
    }
}
