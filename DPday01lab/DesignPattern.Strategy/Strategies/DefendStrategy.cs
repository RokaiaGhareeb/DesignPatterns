using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.DesignPattern.Strategy.Strategies
{
    class DefendStrategy : IStrategy
    {
        public string play()
        {
            return "Defend strategy is used.";
        }
    }
}
