using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    class Pizza : Snabbmat
    {
        #region  --- Konstruktorer ---

        public Pizza()
        {
            Namn = "Pizza";
            Points = 30;
        }

        #endregion

        #region --- Metoder ---

        public override string ToString()
        {
            return Namn;
        }

        public override int SumPoints()
        {
            return Points;
        }

        #endregion
    }
}
