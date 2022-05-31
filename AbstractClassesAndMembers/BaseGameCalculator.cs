using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMembers
{
    public abstract class BaseGameCalculator
    {
        public double Score { get; set; }
        public abstract double CalculateScore(int killedNumber);
    }
}
