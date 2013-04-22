using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    class Knackemacka : Snabbmat
    {

        #region --- Konstruktor ---

        public Knackemacka()
        {
            Namn = "Knäckemacka";
            Points = 1;
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
