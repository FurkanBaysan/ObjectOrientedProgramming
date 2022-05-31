using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMembers
{
    public class MenGameCalculator : BaseGameCalculator
    {
        public override double CalculateScore(int killedNumber)
        {
            this.Score = killedNumber * 10;
            return this.Score;
        }
    }
}
