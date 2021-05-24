using DPday01lab.DesignPatern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.Entities
{
    public class Ball: ISubject
    {
        public BallPosition position { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }
        public void Notify()
        {

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void moveBall(int x, int y, int z)
        {
            this.position.X = x;
            this.position.Y = y;
            this.position.Z = z;

            //Console.WriteLine($"Ball Moved To: X: {this.position.X}, Y: {this.position.Y}, Z: {this.position.Z}");
            this.Notify();
        }
    }
}
