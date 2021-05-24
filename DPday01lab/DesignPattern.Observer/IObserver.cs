using System;
using System.Collections.Generic;
using System.Text;

namespace DPday01lab.DesignPatern.Observer
{
    public interface IObserver
    {
           void  Update(ISubject subject);
        
    }
}
