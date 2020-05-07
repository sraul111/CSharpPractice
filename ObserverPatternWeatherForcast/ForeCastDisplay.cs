using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternWeatherForcast
{
    public class ForeCastDisplay : IObserver<WeatherDetail>
    {
        private IDisposable subscriptionToBeDisposed;

        public void Subscribe(WeatherForecast weatherForecast)
        {
            subscriptionToBeDisposed=weatherForecast.Subscribe(this);
        }

        public void UnSubscribe()
        {
           subscriptionToBeDisposed.Dispose();
        }
        
        public void OnCompleted()
        {
           // throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
           // throw new NotImplementedException();
        }

        public void OnNext(WeatherDetail weatherDetail)
        {
            if (weatherDetail != null)
            {
                Console.WriteLine(
                    $"Update from ForeCastDisplay. Humidity : {weatherDetail.Humidity} , Temprature : {weatherDetail.Temprature}, Pressure : {weatherDetail.Pressure}");
            }
        }
    }
}
