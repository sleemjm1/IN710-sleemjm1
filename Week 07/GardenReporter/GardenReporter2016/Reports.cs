using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public static class Reports
    {
        public static string AreaReport(Garden garden)
        {
            string ownerName = garden.OwnerName;
            string area = garden.GetArea().ToString();
            string reportString = String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, area);
            return reportString;
        }

        public static string AccountBalanceReport(Garden garden)
        {
            string ownerName = garden.OwnerName;
            double charges = garden.GetAccountBalance();
            string reportString = String.Format("{0,-14}:{1,8:f2}", ownerName, "$" + charges.ToString());
            return reportString;
        }
    }
}
