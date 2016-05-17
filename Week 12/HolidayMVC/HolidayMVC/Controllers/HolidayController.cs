using HolidayMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolidayMVC.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            // Avoid literals
            int oneYear = 1;
            int nHolidays = 3;  
            DateTime now = DateTime.Now;
            int year = now.Year;

            // Create our three holidays - would look different in proper architecture
            // each holiday would probably have it's own class and inherit from Holiday base
        
            Holiday haloween = new Holiday
            {
                Name = "Haloween",
                Date = new DateTime(year, 10, 31),
                ImageFileName = "/Images/Holidays/haloween.JPG"
            };

            Holiday boxingDay = new Holiday
            {
                Name = "Boxing Day",
                Date = new DateTime(year, 12, 26),
                ImageFileName = "/Images/Holidays/boxing_day.PNG"
            };

            Holiday queensBirthday = new Holiday
            {
                Name = "Queens Birthday",
                Date = new DateTime(year, 4, 21),
                ImageFileName = "/Images/Holidays/queens_birthday.PNG"
            };

            // Create empty holiday 
            Holiday returnHoliday = new Holiday();

            // Generate random number based on number of holidays
            Random r = new Random();
            int rHoliday = r.Next(nHolidays);

            // Switch on generated number - this would be in a factory
            switch (rHoliday)
            {
                case 0:
                    returnHoliday = haloween;
                    break;
                case 1:
                    returnHoliday = boxingDay;
                    break;
                case 2:
                    returnHoliday = queensBirthday;
                    break;
            }

            // Check to see that we haven't already had the date this year
            // if we have, simply add one year so that we count down till 
            // the next occurance of the holiday
            if (returnHoliday.Date < now)
                returnHoliday.Date = returnHoliday.Date.AddYears(oneYear);

            // Work out & set DaysUntilHoliday property
            returnHoliday.DaysUntilHoliday = (int)(returnHoliday.Date - now).TotalDays;

            // Return the View and pass the holiday
            return View(returnHoliday);
        }
    }
}