using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolidayMVC.Models
{
    public class Holiday
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int? DaysUntilHoliday { get; set; }
        public string ImageFileName { get; set; }
    }
}