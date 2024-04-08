using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance
{
    internal abstract class Vehicle
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();
    }

    class Car : Vehicle
    {
        public override string FormatMe()//helper method//the virtual keyword permits you to 
                                         //take from this method while the abstract also permits but you must make some changes
        {
            return string.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Color);
        }

    }



        sealed class Truck : Vehicle//: represents inheritance
                                    //sealed keyword means nobody can ever inherit fro this class
        {
            public int TowingCapacity { get; set; }
            public override string FormatMe()
            {
                return string.Format("{0} - {1} - {2} Towing unit",
                this.Make,
                this.Model,
                this.TowingCapacity);

            }
        }

        class Bike : Vehicle
        {
            public int SafetyMeasure { get; set; }
            public override string FormatMe()
            {
                return string.Format("{0} - {1} - {2} Headcaps for rider and one passenger",
                    this.Make,
                    this.Model,
                    this.Year,
                    this.SafetyMeasure);
            }



        }

        class Bycicle : Vehicle
        {
            public string Route { get; set; }
            public override string FormatMe()
            {
                return string.Format("{0} - {1} -{2} make use of the service lane",
                    this.Make,
                    this.Model,
                    this.Year,
                    this.Route);
            }

        }
}




