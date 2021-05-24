using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.DesignPattern.Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public void AssignPlayer(Component component)
        {
            this._component = component;
        }

        public override string PassBall()
        {
            if (this._component != null)
            {
                return this._component.PassBall();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
