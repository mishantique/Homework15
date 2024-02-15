using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class ArithProgression : Iseries
    {
        int StartVal;
        int x;
        int CurrVal;
        int step;
        public int GetNext()
        {
            CurrVal += step;
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
