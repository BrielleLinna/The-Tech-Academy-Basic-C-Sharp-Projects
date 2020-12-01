using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOneGame
{
    public class TwentyOneDealer: Dealer
    {
        public List<Card> MyProperty { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }
}
