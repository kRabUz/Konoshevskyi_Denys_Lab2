using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_1
{
    class Star
    {
        private string star;
        public string StarOfSystem { get { return star; } set { star = value; } }
        public Star(string star)
        {
            this.star = star;
        }
        public string GetStar()
        {
            return this.star;
        }
    }
}
