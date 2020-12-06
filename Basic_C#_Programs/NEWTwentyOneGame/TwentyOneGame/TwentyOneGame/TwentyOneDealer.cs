using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneDealer : Dealer
    {
        public TwentyOneGame Dealer { get; set; }
        private List<Cards> _hand = new List<Cards>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } 
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }
}

