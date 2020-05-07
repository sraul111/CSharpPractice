using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternWeatherForcast
{
    public class WeatherForecast : ISubject<WeatherDetail>
    {
        private List<IObserver<WeatherDetail>> observers;
        private List<WeatherDetail> weatherdetails;
        private WeatherDetail weatherdetail;

        public WeatherForecast()
        {
            observers = new List<IObserver<WeatherDetail>>();
            weatherdetails = new List<WeatherDetail>();
            weatherdetail = new WeatherDetail();
        }

        // usually in pub sub pattern the publisher do not unsubscribe the subscriber
        //but instead the subscriber unsubscribe by itself when it feels like.
        //But still if we want to give power to the publisher to unsubscribe the subscriber 
        //for any reason we have to implement the below method
        public void removeObserver(IObserver<WeatherDetail> observer)
        {
            var unsubscribe = new Unsubscriber(observers, observer);
            unsubscribe.Dispose();
        }

        public void AddNewWeatherDetail(double tempreture, double humidity, double pressure)
        {
            weatherdetail.Humidity = humidity;
            weatherdetail.Pressure = pressure;
            weatherdetail.Temprature = tempreture;
            if (!weatherdetails.Exists(item=> item.Humidity == humidity &&  item.Pressure == pressure &&  item.Temprature == tempreture))
            {
                weatherdetails.Add(weatherdetail);
                NotifyObservers();
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.OnNext(weatherdetail);
            }
        }

        public IDisposable Subscribe(IObserver<WeatherDetail> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber(observers, observer);
        }

        public void SubscriptionDetails()
        {
            Console.WriteLine($"the observers count now is {observers.Count}");
        }
    }
}
