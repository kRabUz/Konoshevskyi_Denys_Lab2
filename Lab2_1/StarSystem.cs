using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_1
{
    class StarSystem
    {
        private Star star;
        private int satellite_Amount;
        private int planet_Amount;
        public int Planet_Amount { get { return planet_Amount; } set { planet_Amount = value; } }
        public Star Star { get { return star; } set { star = value; } }
        public int Satellite_Amount { get { return satellite_Amount; } set { satellite_Amount = value; } }

        public StarSystem(Star star,int planet_Amount, int satellite_Amount)
        {
            this.star = star;
            this.planet_Amount = planet_Amount;
            this.satellite_Amount = satellite_Amount;
        }
        public override string ToString()
        {
            return "Зоряна система має " + planet_Amount + " планет, в яких " + satellite_Amount + " супутникiв, та зiрку "+ star.StarOfSystem;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is StarSystem)) return false;
            return (this.planet_Amount == ((StarSystem)obj).planet_Amount) && (this.satellite_Amount == ((StarSystem)obj).satellite_Amount) && (this.star.StarOfSystem == ((StarSystem)obj).star.StarOfSystem);
        }
        public override int GetHashCode()
        {

            return planet_Amount.GetHashCode() ^ satellite_Amount.GetHashCode() ^ star.StarOfSystem.GetHashCode();
        }
    }
}
