using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public static class Reports
    {
        public static double AreaReport(Garden garden)
        {
            return garden.GetArea();
        }

        public static double AccountBalanceReport(Garden garden)
        {
            return garden.GetAccountBalance();
        }
    }
}
