using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using NUnit.Framework;
using SingletonPattern;

namespace SingletonPatternTest
{
    [TestFixture]
    class ChocolateBoilerTest
    {
        [Test]
        public void TestInstanceCount()
        {
            ChocolateBoiler.GetInstance();
            ChocolateBoiler.GetInstance();
            var instance = ChocolateBoiler.GetInstance();
            Assert.AreEqual(1,ChocolateBoiler.count);
            instance.Fill();

        }

       
    }
}
