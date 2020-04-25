using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<BaggageInfo>> observers;
        private IObserver<BaggageInfo> observer;

        public Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
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