using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    public abstract class Mat : IPointsDish
    {
        #region --- Properties ---

        public string Namn { get; set; }
        public int Points { get; set; }

        #endregion

        #region  --- Metoder ---

        virtual public int SumPoints()
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
