using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private const double DefaultFuelConsumption = 1.25; 
        private double kilometers;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;

            FuelConsumption = DefaultFuelConsumption;
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public double Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }


        public virtual double FuelConsumption { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * FuelConsumption;
        }
        



    }
}
