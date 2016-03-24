using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherObserver;

namespace UnitTestProject
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
        }
    }
}
