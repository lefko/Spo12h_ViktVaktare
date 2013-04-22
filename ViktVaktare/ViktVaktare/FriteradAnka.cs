using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    public class FriteradAnka : KottRatt
    {
        public FriteradAnka()
        {
            Namn = "Friterad Anka";
            Points = 22;
        }

        public override int SumPoints()
        {
            return Points;
        }

        public override string ToString()
        {
            return Namn;
        }
    }
}
