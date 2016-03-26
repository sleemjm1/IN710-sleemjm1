using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using WeatherObserver;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ListBox listBox = new ListBox();
        WeatherSubject weatherSubject = new WeatherSubject();
       
        [TestMethod]
        public void TemperatureObserver_UpdateValidTemperature_ReturnsComputedTemperature()
        {
            TemperatureObserver temperatureObserver = new TemperatureObserver(listBox, weatherSubject);
            temperatureObserver.Update(15, 50, 100);

            double expected = 15.00;
            double actual = temperatureObserver.currComputedTemperature;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TemperatureObserver_UpdateValidHumidity_ReturnsComputedHumidity()
        {
            TemperatureObserver temperatureObserver = new TemperatureObserver(listBox, weatherSubject);
            temperatureObserver.Update(15, 50, 102);

            double expected = 50.00;
            double actual = temperatureObserver.currComputedHumidity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TemperatureObserver_UpdateValidPressure_ReturnsComputedPressure()
        {
            TemperatureObserver temperatureObserver = new TemperatureObserver(listBox, weatherSubject);
            temperatureObserver.Update(15, 50, 102);

            double expected = 102.00;
            double actual = temperatureObserver.currComputedPressure;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AverageObserver_ComputeAverageTemperatureWithTwoReadings_ReturnsAverage()
        {
            AverageObserver averageObserver = new AverageObserver(listBox, weatherSubject);
            averageObserver.Update(15, 50, 102);
            averageObserver.Update(20, 50, 102);

            double expected = 17.50;
            double actual = averageObserver.currComputedTemperature;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ForecastObserver_PredictForecastWithOneReading_ReturnsPrediction()
        {
            ForecastObserver forecastObserver = new ForecastObserver(listBox, weatherSubject);
            forecastObserver.Update(15, 50, 102);

            string expected = "asteroids will hit the earth.";
            string actual = forecastObserver.prediction;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ForecastObserver_PredictForecastWithTwoReadings_ReturnsPrediction()
        {
            ForecastObserver forecastObserver = new ForecastObserver(listBox, weatherSubject);
            forecastObserver.Update(15, 50, 102);
            forecastObserver.Update(15, 50, 98);

            string expected = "showers likely, perhaps hail";
            string actual = forecastObserver.prediction;

            Assert.AreEqual(expected, actual);
        }
    }
}
