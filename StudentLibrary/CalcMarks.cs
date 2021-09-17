using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class CalcMarks : ICalcMarks
    {
        public int Calculate(int Subject1, int Subject2, int Subject3)
        {
            int TotalMarks = (Subject1 + Subject2 + Subject3);
            return TotalMarks;
        }
    }
}
