using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        //instantiating variables for scoring
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }
        //random instance
        private Random _random;
        //generate random throws
        public Dart(Random random)
        {
            _random = random;
        }
        //generate score, multiplier, and random throws
        public void Throw()
        {
            Score = _random.Next(0, 21);

            int multiplier = _random.Next(1, 101);
            if (multiplier > 95) IsTriple = true;
            else if (multiplier > 90) IsDouble = true;
        }
    }
}
