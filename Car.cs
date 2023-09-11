using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB1
{
    class Car
    {
        public Car(int NOD, int AOH, string CT, string CB, string CM, bool IEC)
        {
            Number_of_doors = NOD;
            Amount_of_horsepower = AOH;
            Car_type = CT;
            Car_brand = CB;
            Car_model = CM;
            Is_electric_car = IEC;
        }
        public Car() { }

        private int number_of_doors;

        private int amount_of_horsepower;

        public int Number_of_doors
        {
            get
            {
                return number_of_doors;
            }
            set
            {
                if(value < 0)
                {
                    number_of_doors = 0;
                }
                else if(value > 5)
                {
                    number_of_doors = 5;
                }
                else
                {
                    number_of_doors = value;
                }
            }
        }
        public int Amount_of_horsepower
        {
            get
            {
                return amount_of_horsepower;
            }
            set
            {
                if (value < 0)
                {
                    amount_of_horsepower = 0;
                }
                else if (value > 2028)
                {
                    amount_of_horsepower = 2028;
                }
                else
                {
                    amount_of_horsepower = value;
                }
            }
        }
        public string Car_type { get; set; }

        public string Car_brand { get; set; }

        public string Car_model { get; set; }
        public string Body_type { get; set; }
        public bool Is_electric_car { get; set; }

    }
}
