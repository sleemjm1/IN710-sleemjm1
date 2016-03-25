using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public class ForecastObserver : WeatherObserver
    {
        string dryness;
        int? previousPressure;  // nullable int
        string prediction;

        public ForecastObserver(ListBox listBox, WeatherSubject weatherSubject) : base(listBox, weatherSubject)
        {
            previousPressure = null;
        }

        // In this Update method, instead of writing to currComputedTemperature, etc. In the base class, we will be writing to
        // Our local variables instead. This is because we will be using them in our overridden Display method below
        // This update should be based entirely on the change in barometric pressure:
        //          Over 102:
        //                      Rising:             Continued fair
        //                      Slowly Falling:     Fair
        //                      Rapidly Falling:    Cloudy, warmer
        //          100-102:    
        //                      Rising:             Same as present
        //                      Slowly Falling:     Little change
        //                      Rapidly Falling:    Precipitation likely
        //          Below 100:  
        //                      Rising:             Clearing cooler
        //                      Slowly Falling:     Precipitation
        //                      Rapidly Falling:    Storm
        public override void Update(int currTemperature, int currHumidity, int currPressure)    
        {
            string state;
            currComputedTemperature = currTemperature;  // will use this when displaying

            if (previousPressure == null)
            {
                previousPressure = currPressure;
                // we will make up the forecast as we have no way of telling
                prediction = "asteriods will hit the earth.";
            }
            else
            {
                int difference = currPressure - (int)previousPressure;  // if this value is negative - we are falling

                if (difference < 0 && difference > -2)                  // slowly falling 
                    state = "Slowly Falling";
                else if (difference < -2)                               // rapidly falling
                    state = "Rapidly Falling";
                else                                                    // else we must be rising
                    state = "Rising";

                switch (state)
                {
                    case "Rising":
                        if (currPressure > 102)
                            prediction = "continued fair weather";          // Rising  Continued fair weather
                        else if (currPressure < 102 && currPressure <100)
                            prediction = "not likely to change";            // Same as present
                        else
                            prediction = "clearing and cooler";             // Clearing cooler
                        break;
                    case "Slowly Falling":
                        if (currPressure > 102)
                            prediction = "fair weather"; // Fair
                        else if (currPressure < 102 && currPressure <100)
                            prediction = "little change expected";          // Little change
                        else
                            prediction = "showers forming";                 // Precipitation
                        break;
                    case "Rapidly Falling":
                        if (currPressure > 102)
                            prediction = "warmer weather but cloudy";       // Cloudy, Warmer
                        else if (currPressure < 102 && currPressure <100)
                            prediction = "showers likely, perhaps hail";    // Precipitation likely
                        else
                            prediction = "stormy weather expected";         // Storm
                        break;
                }   // end switch
                
            }

            if (currHumidity > 70)
                dryness = "very humid";
            else if (currHumidity > 50 && currHumidity < 70)
                dryness = "humid";
            else
                dryness = "dry";
        }


        // Overridden Display method. This needs to act differently to the parent's Display method because we are going to be 
        // displaying strings rather than doubles. We will build our strings using the variables we have set in the Update method
        public override void Display()
        {
            listBox.Items.Clear();
            listBox.Items.Add("You can expect a high of " + currComputedTemperature + " degrees.");
            listBox.Items.Add("It should be a " + dryness + " day.");
            listBox.Items.Add("Forecast prediction: " + prediction);
        }

    }
}
