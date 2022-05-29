using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class WomanScoreCalculator : BaseScoreCalculator
    {
        public override double CalculateScore(int killedNumber)
        {
            this.Score = killedNumber * 30;
            return this.Score;
        }
    }
}
