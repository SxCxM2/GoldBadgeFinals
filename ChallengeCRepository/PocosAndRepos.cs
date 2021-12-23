using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCRepository
{
    public class PocosAndRepos
    {

        public int Hamburgers { get; set; }
        public int HotDogs { get; set; }
        public int VeggieBurgers { get; set; }
        public int IceCream { get; set; }
        public int PopcornBags { get; set; }

        public decimal PriceOfPopcorn = 1.5m;
        public decimal PriceOfIceCream = 2.5m;
        public decimal PriceOfHotDog = 3.5m;
        public decimal PriceOfVeggieBurger = 4.5m;
        public decimal PriceOfHamburger = 4.75m;

        public decimal PriceOfPackaging = 1.25m;

    }
}
