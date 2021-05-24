using DPday01lab.DesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.Entities
{
    public class FieldPlayer : Component
    {
        public override string PassBall()
        {
            return "FieldPlayer : Can pass ball";
        }
    }
}
