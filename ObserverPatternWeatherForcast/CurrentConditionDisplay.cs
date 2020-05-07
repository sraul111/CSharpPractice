using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObserverPatternWeatherForcast
{
    public class CurrentConditionDisplay : IObserver<WeatherDetail>
    {
        private IDisposable subcriptionToDispose;
        public void Subscribe(WeatherForecast weatherforcast)
        {
            subcriptionToDispose = weatherforcast.Subscribe(this);
        }

        public void UnSubscribe()
        {
            subcriptionToDispose.Dispose();
        }
        public void OnCompleted()
        {
            // not required to implement now
        }

        public void OnError(Exception error)
        {
            // not required to implement now
        }

        public void OnNext(WeatherDetail weatherDetail)
        {
            if (weatherDetail != null)
            {
                Console.WriteLine($"Update from CurrentConditionDisplay. Humidity : {weatherDetail.Humidity} , Temprature : {weatherDetail.Temprature}, Pressure : {weatherDetail.Pressure}" );
            }

        }
    }
}
