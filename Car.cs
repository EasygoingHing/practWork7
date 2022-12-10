﻿namespace WpfApp7
{
    internal class Car
    {
        private string _brand;
        private int _numberofCylinders;
        private int _power;

        public Car(string brand, int numberofCylinders, int power)
        {
            _brand = brand;
            _numberofCylinders = numberofCylinders;
            _power = power;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int NumberOfCylinders
        {
            get { return _numberofCylinders; }
            set { _numberofCylinders = value; }
        }

        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public void  SetParams(string brand)
        {
            Brand = brand;
        }

        public virtual void SetParams(int value, char param)
        {
            if (param == 'n')
            {
                NumberOfCylinders = value;
            }
            else if (param == 'p')
            {
                Power = value;
            }
        }

        public void SetParams(int numberofCylinders, int power, string brand)
        {
            Brand = brand;
            NumberOfCylinders = numberofCylinders;
            Power = power;
        }

        public static Car operator ++(Car car)
        {
            return new Car(car.Brand, car.NumberOfCylinders, car.Power++);
        }

        public static bool operator >(Car car1, Car car2)
        {
            return car1.Power > car2.Power && car1.NumberOfCylinders > car2.NumberOfCylinders;
        }

        public static bool operator <(Car car1, Car car2)
        {
            return car1.Power < car2.Power && car1.NumberOfCylinders < car2.NumberOfCylinders;
        }
    }
}
