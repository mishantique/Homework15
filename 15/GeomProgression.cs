using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class GeomProgression : Iseries
    {
        int x;
        int StartVal;
        int step;
        int CurrVal;
        public int GetNext()
        {
            CurrVal *= step;
            return CurrVal;
        }

        public void Reset()
        {
            CurrVal = StartVal;
        }

        public void SetStart(int x)
        {
            StartVal = x;
            CurrVal = x;
        }
        public void SetStep(int step)
        {
            this.step = step;
        }
    }
}
