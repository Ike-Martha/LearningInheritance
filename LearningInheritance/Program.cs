using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using LearningInheritance;

namespace LearningInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "333li";
            myCar.Year = 2001;
            myCar.Color = "gray";
            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "BMW";
            myTruck.Model = "999JK";
            myTruck.Year = 2005;
            myTruck.Color = "red";
            myTruck.TowingCapacity = 200;
            printVehicleDetails(myTruck);

            Bike myBike = new Bike();
            myBike.Make = "BNW";
            myBike.Model = "lk9";
            myBike.Year = 2010;
            myBike.Color = "Blue";
            myBike.Year = 2019;
            myBike.SafetyMeasure = 2;
            printVehicleDetails(myBike);


            Bycicle myBycicle = new Bycicle();
            myBycicle.Make = "BMW";
            myBycicle.Model = "xxx";
            myBycicle.Year = 2020;
            myBycicle.Color = "Green";
            myBycicle.Route = "Service Lane";
            myBycicle.brake = "One brake needed";
            printVehicleDetails(myBycicle);
            Console.ReadLine();

        }



        private static void printVehicleDetails(Vehicle vehicle)//helper method for program class
        {

            Console.WriteLine("Here are the Vehicle's details: {0}", vehicle.FormatMe());
        }


    }
}
