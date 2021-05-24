using DPday01lab.DesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.Entities
{
    class Team
    {
        private IStrategy _strategy;

        public Team()
        { }

        public Team(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public string changeStrategy()
        {
            string result = this._strategy.play();
            return result;
            //Console.WriteLine(result);
        }
    }
}
