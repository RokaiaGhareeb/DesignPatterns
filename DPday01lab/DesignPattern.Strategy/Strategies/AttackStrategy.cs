using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.DesignPattern.Strategy.Strategies
{
    class AttackStrategy : IStrategy
    {
        public string play()
        {
            return "Attack strategy is used.";
        }
    }
}
