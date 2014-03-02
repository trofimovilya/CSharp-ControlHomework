// Трофимов Илья. Группа 172ПИ. Вариант 44

using System;
using CommonWorkingLibrary;

namespace SweetLibrary
{
    public abstract class Sweets // Базовый класс "Сладости"
    {
        private string _name; // Наименование
        private string _country; // Страна производитель
        private double _costPerKg; // Стоимость за килограмм
        private int _minTemperature; // Минимальная температура хранения
        private int _maxTemperature; // Максимальная температура хранения
        private int _calories;  // Калорийность
        private uint _shelfLife; // Срок годности 

        protected Sweets()
        {
            _name = String.Empty;
            _country = String.Empty;
            _costPerKg = 0;
            _minTemperature = -101;
            _maxTemperature = 101;
            _calories = -1;
            _shelfLife = 0;
        }

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Length > 200)
                    throw new Exception(Literals.ExceptionMessages.NameLength);

                _name = value; 
            }
        }

        public string Country
        {
            get { return _country; }
            set
            {
                if (value.Length > 75)
                    throw new Exception(Literals.ExceptionMessages.ContryLength);
                
                foreach (var ch in value)
                    if (!(char.IsLetter(ch) || ch == '-' || ch == '.' || ch == ',' || ch == ' '))
                        throw new Exception(Literals.ExceptionMessages.CountryName);

                _country = value;
            }
        }

        public double Cost
        {
            get { return _costPerKg; }
            set 
            {
                if (value < 0)
                    throw new Exception(Literals.ExceptionMessages.CostEx);

                _costPerKg = value;
            }
        }

        public int MinTemperature
        {
            get { return _minTemperature; }
            set
            {
                if (value < -101)
                    throw new Exception(Literals.ExceptionMessages.MinTlow);
                
                else if (value > 100)
                    throw new Exception(Literals.ExceptionMessages.MinThigh);
                
                else if (MaxTemperature != 101 && value > MaxTemperature)
                    throw new Exception(Literals.ExceptionMessages.MinMax);
                
                _minTemperature = value;
            }
        }

        public int MaxTemperature
        {
            get { return _maxTemperature; }
            set 
            {
                if (value < -100)
                    throw new Exception(Literals.ExceptionMessages.MaxTlow);
                
                else if (value > 101)
                    throw new Exception(Literals.ExceptionMessages.MaxThigh);
                
                else if (MinTemperature != -101 && value < MinTemperature)
                    throw new Exception(Literals.ExceptionMessages.MaxMin);
                
                _maxTemperature = value;
            }
        }

        public uint ShelfLife
        {
            get { return _shelfLife; }
            set 
            {
                if (value > 120)
                    throw new Exception(Literals.ExceptionMessages.ShelfLifeEx);
                
                _shelfLife = value; 
            }
        }

        public int Calories
        {
            get { return _calories; }
            set 
            {
                if (value < -1)
                    throw new Exception(Literals.ExceptionMessages.CaloriesLessZero);

                _calories = value; 
            }
        }

        public abstract bool IsOverdue
        {
            get;
        }

        public abstract string GetKind
        {
            get;
        }
    }
}