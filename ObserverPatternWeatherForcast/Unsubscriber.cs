using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternWeatherForcast
{
    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<WeatherDetail>> observers;
        private readonly IObserver<WeatherDetail> observer;

        public Unsubscriber(List<IObserver<WeatherDetail>> observers, IObserver<WeatherDetail> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }
        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}
