using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRental
{
    class CartProduct
    {   
        public String Type { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public String Dimensions { get; set; }
        public String Colour { get; set; }
        public int EnergyConsumption { get; set; }
        public int MonthlyFee { get; set; }
        public int Periods_Month { get; set; }
        public int Cost_in_pound { get; set; }
    }
}
