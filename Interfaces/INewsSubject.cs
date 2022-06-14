using SCD_LAB_W14.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_LAB_W14.Interfaces
{
    public interface INewsSubject
    {
        void RegisterObserver(INewsObserver observer);
        void RemoveObserver(INewsObserver observer);
        void NotifyObservers(string newstype);
    }
}
