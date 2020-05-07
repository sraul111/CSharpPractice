using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ObserverPatternWeatherForcast;

namespace CommonTestProjectNUnit
{
    class ObserverPatternWeatherForecastTest
    {
        [Test]
        public void Test()
        {
           WeatherForecast publisher = new WeatherForecast();
           CurrentConditionDisplay subscriber1 = new CurrentConditionDisplay();
           subscriber1.Subscribe(publisher);

           publisher.SubscriptionDetails();
           publisher.AddNewWeatherDetail(2,3,4);
           //publisher.AddNewWeatherDetail(2,3,4);
           publisher.AddNewWeatherDetail(2,5,4);
        }
    }
}
