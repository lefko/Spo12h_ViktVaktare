using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    public abstract class KottRatt : Mat
    {


        #region --- Metoder ---
    
        override public int SumPoints()
        {
            return Points;
        }

        public override string ToString()
        {
            return Namn;
        }

        #endregion
    }
}
