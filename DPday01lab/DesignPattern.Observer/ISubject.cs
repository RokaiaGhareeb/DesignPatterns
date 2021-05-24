using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.DesignPatern.Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
