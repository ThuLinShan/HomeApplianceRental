using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRental
{
    class Product
    {
        private int id;
        private String type;
        private String brand;
        private String model;
        private String dimensions;
        private String colour;
        private int energyConsumption;
        private int monthlyFee;
        private int monthlyRentalPeriod;

        public int Id { get; set; }
        public String Type { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public String Dimensions { get; set; }
        public String Colour { get; set; }
        public int EnergyConsumption { get; set; }
        public int MonthlyFee { get; set; }
        public int MonthlyRentalPeriod { get; set; }

    }
}
