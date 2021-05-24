using DPday01lab.DesignPatern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.Entities
{
    public class Refree : IObserver
    {
        public BallPosition ballPosition { get; set; }
        public void Update(ISubject subject)
        {
            if ((subject as Ball).position.X != ballPosition.X || (subject as Ball).position.Y != ballPosition.Y || (subject as Ball).position.Z != ballPosition.Z)
            {
                this.ballPosition.X = (subject as Ball).position.X;
                this.ballPosition.Y = (subject as Ball).position.Y;
                this.ballPosition.Z = (subject as Ball).position.Z;
                //Console.WriteLine($"Refree: Run to ball at (${ballPosition.X}, ${ballPosition.Y}, ${ballPosition.Z}).");
            }
        }
    }
}
