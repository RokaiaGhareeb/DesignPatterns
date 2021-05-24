using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.DesignPattern.Decorator.ConcreteDecorators
{
    public class Defender : Decorator
    {
        public Defender(Component comp) : base(comp)
        {
        }

        public override string PassBall()
        {
            return $"Play as Defender and {base.PassBall()})";
        }
    }
}
