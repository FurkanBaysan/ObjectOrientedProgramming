using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMembers
{
    public class WomanGameCalculator : BaseGameCalculator
    {
        public override double CalculateScore(int killedNumber)
        {
            this.Score = killedNumber * 20;
            return this.Score;
        }
    }
}
