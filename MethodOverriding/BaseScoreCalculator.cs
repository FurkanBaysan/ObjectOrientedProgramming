using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class BaseScoreCalculator
    {
        public double Score { get; set; }

        public virtual double CalculateScore(int killedNumber)
        {
            this.Score = killedNumber * 10;
            return this.Score;
        }
    }
}
