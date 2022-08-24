using System;

namespace _1.VehiclesExtension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            string[] truckInput = Console.ReadLine().Split();
            string[] busInput = Console.ReadLine().Split();
            int numberOfLines = int.Parse(Console.ReadLine());

            double carFuelQuin = double.Parse(carInput[1]);
            double truckFuelQuin = double.Parse(truckInput[1]);
            double busFuelQuin = double.Parse(busInput[1]);
            double carConsump = double.Parse(carInput[2]);
            double truckConsump = double.Parse(truckInput[2]);
            double busConsump = double.Parse(busInput[2]);
            int carTank = int.Parse(carInput[3]);
            int truckTank = int.Parse(truckInput[3]);
            int busTank = int.Parse(busInput[3]);

            Car car = new Car(carFuelQuin, carConsump, carTank);
            Truck truck = new Truck(truckFuelQuin, truckConsump, truckTank);
            Bus bus = new Bus(busFuelQuin, busConsump, busTank);

            if (carFuelQuin > carTank)
            {
                car.FuelQuantity = 0;
            }
            if (truckFuelQuin > truckTank)
            {
                truck.FuelQuantity = 0;
            }
            if (busFuelQuin > busTank)
            {
                bus.FuelQuantity = 0;
            }


            for (int i = 0; i < numberOfLines; i++)
            {
                double result = 0;
                string[] command = Console.ReadLine().Split();
                double kmNeed = double.Parse(command[2]);
                double fuelIn = double.Parse(command[2]);

                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        result = car.Drive() - kmNeed;

                        if (result >= 0)
                        {
                            car.FuelQuantity -= kmNeed * (car.Consumption + 0.9);
                            Console.WriteLine($"Car travelled {kmNeed} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (command[1] == "Truck")
                    {
                        result = truck.Drive() - kmNeed;

                        if (result >= 0)
                        {
                            truck.FuelQuantity -= kmNeed * (truck.Consumption + 1.6);
                            Console.WriteLine($"Truck travelled {kmNeed} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                    else
                    {
                        result = bus.Drive() - kmNeed;

                        if (result >= 0)
                        {
                            bus.FuelQuantity -= kmNeed * (bus.Consumption + 1.4);
                            Console.WriteLine($"Bus travelled {kmNeed} km");
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (fuelIn <= 0)
                    {
                        Console.WriteLine("Fuel must be a positive number");
                    }
                    else
                    {
                        if (command[1] == "Car")
                        {
                            if (car.FuelQuantity + fuelIn <= carTank)
                            {
                                car.FuelQuantity += fuelIn;
                            }
                            else
                            {
                                Console.WriteLine($"Cannot fit {fuelIn} fuel in the tank");
                            }
                        }
                        else if (command[1] == "Truck")
                        {
                            if (truck.FuelQuantity + fuelIn <= truckTank)
                            {
                                truck.FuelQuantity += fuelIn * 0.95;
                            }
                            else
                            {
                                Console.WriteLine($"Cannot fit {fuelIn} fuel in the tank");
                            }
                        }
                        else if (command[1] == "Bus")
                        {
                            if (bus.FuelQuantity + fuelIn <= busTank)
                            {
                                bus.FuelQuantity += fuelIn;
                            }
                            else
                            {
                                Console.WriteLine($"Cannot fit {fuelIn} fuel in the tank");
                            }
                        }
                    }
                }
                else if (command[0] == "DriveEmpty")
                {
                    result = (bus.FuelQuantity / bus.Consumption) - kmNeed;

                    if (result >= 0)
                    {
                        bus.FuelQuantity -= kmNeed * bus.Consumption;
                        Console.WriteLine($"Bus travelled {kmNeed} km");
                    }
                    else
                    {
                        Console.WriteLine("Bus needs refueling");
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
