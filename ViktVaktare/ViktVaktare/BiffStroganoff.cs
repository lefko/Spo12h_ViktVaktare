using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    public class BiffStroganoff : KottRatt
    {

        public BiffStroganoff()
        {
            Points = 12;
            Namn = "Biff Stroganoff";
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
