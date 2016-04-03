using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public static class Reports
    {
        // Static class with static methods which will be used to create a delegate
        // These two methods will each return a string which will be a report containing
        // the relevant information for the type of report required
        public static string AreaReport(Garden garden)
        {
            string ownerName = garden.OwnerName;
            string area = garden.GetArea().ToString();
            string reportString = String.Format("{0,-14}:{1,8:F2}", garden.OwnerName, area);
            return reportString;
        }

        public static string AccountBalanceReport(Garden garden)
        {
            string ownerName = garden.OwnerName;
            string charges = garden.GetAccountBalance().ToString();
            string reportString = String.Format("{0,-14}:{1,8:F2}", ownerName, "$" + charges);
            return reportString;
        }
    }
}
