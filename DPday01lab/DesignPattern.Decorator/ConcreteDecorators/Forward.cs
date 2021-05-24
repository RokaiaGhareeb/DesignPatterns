using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.DesignPattern.Decorator.ConcreteDecorators
{
    public class Forward : Decorator
    {
        public Forward(Component comp) : base(comp)
        {
        }

        public override string PassBall()
        {
            return $"Play as Forward and {base.PassBall()})";
        }
    }
}
