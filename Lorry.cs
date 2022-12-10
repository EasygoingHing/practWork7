using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    internal class Lorry : Car
    {
        private int _loadcapacity;        

        public Lorry(string brand, int numberofCylinders, int power, int loadcapacity) : 
            base(brand, numberofCylinders, power)
        {
            _loadcapacity = loadcapacity;   
        }

        public int Loadcapacity //грузоподъёмность кузова
        {
            get { return _loadcapacity; }
            set { _loadcapacity = value; }
        }       

        public override void SetParams(int value, char param)
        {
            if (param == 'n')
            {
                NumberOfCylinders = value;
            }
            else if (param == 'p')
            {
                Power = value;
            }
            else if (param == 'l')
            {
                Loadcapacity = value;
            }
        }

        public void SetParams(int numberofCylinders, int power, string brand, int loadcapacity)
        {
            Brand = brand;
            NumberOfCylinders = numberofCylinders;
            Power = power;
            Loadcapacity = loadcapacity;
        }

        public static Lorry operator ++(Lorry lorry)
        {
            return new Lorry(lorry.Brand, lorry.NumberOfCylinders, lorry.Power++, lorry.Loadcapacity);
        }

        public static bool operator >(Lorry lorry1, Lorry lorry2)
        {
            return lorry1.Power > lorry2.Power && lorry1.NumberOfCylinders > lorry2.NumberOfCylinders;
        }

        public static bool operator <(Lorry lorry1, Lorry lorry2)
        {
            return lorry1.Power < lorry2.Power && lorry1.NumberOfCylinders < lorry2.NumberOfCylinders;
        }
    }
}
