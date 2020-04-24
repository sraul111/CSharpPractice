using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SingletonPattern;

namespace SingletonPatternTest
{
    [TestFixture]
    public class ChocolateBoilerEarlyInstanceShould
    {
        [Test]
        public void HaveOnlyOneInstance()
        {
            ChocolateBoilerEarlyInstance.GetInstance();
            ChocolateBoilerEarlyInstance.GetInstance();
            ChocolateBoilerEarlyInstance.GetInstance();

            Assert.AreEqual(1,ChocolateBoilerEarlyInstance.count);

        }
    }
}
