using DPday01lab.DesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.Entities
{
    public class Goalkeeper : Component
    {
        public override string PassBall()
        {
            return "GoalKeeper : Can pass ball";
        }
    }
}
