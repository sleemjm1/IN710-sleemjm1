using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using WeatherObserver;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TemperatureObserver_UpdateValidTemperature_ReturnsComputedTemperature()
        {
            ListBox listBox = new ListBox();
            WeatherSubject weatherSubject = new WeatherSubject();
            TemperatureObserver temperatureObserver = new TemperatureObserver(listBox, weatherSubject);

            double expected = 15.00;

            temperatureObserver.Update(15, 500, 100);

            double actual = temperatureObserver.currComputedTemperature;

            Assert.AreEqual(expected, actual);
        }
    }
}
