using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    public abstract class Dessert : Mat
    {


        #region --- Metoder ---

        public virtual int SumPoints()
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
