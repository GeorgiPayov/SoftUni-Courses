using System;
using System.Collections.Generic;
using System.Text;

namespace _1.VehiclesExtension
{
    public class Truck : FuelQuantity, Consumption, TankCapacity
    {
        public Truck(double fuelQuantity, double consumption, int tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.Consumption = consumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }
        public double Consumption { get; set; }
        public int TankCapacity { get; set; }

        public double Drive()
        {
            double drived = FuelQuantity / (Consumption + 1.6);
            return drived;
        }
    }
}
