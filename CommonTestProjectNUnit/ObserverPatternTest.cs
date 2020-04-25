using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ObserverPattern;

namespace CommonTestProjectNUnit
{


    
    class ObserverPatternTest
    {

        [Test]
        public void TestBaggageHandler()
        {
            BaggageHandler provider = new BaggageHandler();
            ArrivalMonitor observer1 = new ArrivalMonitor("BaggageClaimMonitor1");
            ArrivalMonitor observer2 = new ArrivalMonitor("SecurityExit");

            provider.BaggageStatus(712, "Detroit", 3);
            observer1.Subscribe(provider);
            provider.BaggageStatus(712, "Kalamazoo", 3);
            provider.BaggageStatus(400, "New York-Kennedy", 1);
            provider.BaggageStatus(712, "Detroit", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "San Francisco", 2);
            provider.BaggageStatus(712);
            observer2.Unsubscribe();
            provider.BaggageStatus(400);
            provider.LastBaggageClaimed();

        }
    }
}
