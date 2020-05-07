using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternWeatherForcast
{
    interface ISubject<T> : IObservable<T>
    {
        void removeObserver(IObserver<T> observer);
        void NotifyObservers();
    }
}
