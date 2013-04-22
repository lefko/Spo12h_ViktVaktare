using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    class Tartbit : Dessert
    {
        #region --- Konstruktorer ---
       
        public Tartbit()
        {
            Namn = "Tårtbit";
            Points = 15;
        }

        #endregion

        #region --- Metoder ---

        public override int SumPoints()
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
