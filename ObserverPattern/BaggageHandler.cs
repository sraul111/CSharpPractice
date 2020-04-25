﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class BaggageHandler: IObservable<BaggageInfo>
    {
        private List<IObserver<BaggageInfo>> observers;
        private List<BaggageInfo> flights;

        public BaggageHandler()
        {
             observers = new List<IObserver<BaggageInfo>>();
             flights = new List<BaggageInfo>();
        }
        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            //check whether observer is  already registered , if not add it.
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                //provide observer with existing data
                foreach (var item in flights)
                    observer.OnNext(item);
            }

            return new Unsubscriber(observers, observer);
        }

        //failed to 
        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo,String.Empty,0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            // Carousel is assigned, so add new info object to list.
            if (carousel > 0 && !flights.Contains(info))
            {
                flights.Add(info);
                foreach (var observer in observers)
                    observer.OnNext(info);
            }
            else if (carousel == 0)
            {
                // Baggage claim for flight is done
                var flightsToRemove = new List<BaggageInfo>();
                foreach (var flight in flights)
                {
                    if (info.FlightNumber == flight.FlightNumber)
                    {
                        flightsToRemove.Add(flight);
                        foreach (var observer in observers)
                            observer.OnNext(info);
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                    flights.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
        }

        public void LastBaggageClaimed()
        {
            foreach (var observer in observers)
                observer.OnCompleted();

            observers.Clear();
        }
    }
}
