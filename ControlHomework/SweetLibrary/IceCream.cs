// Трофимов Илья. Группа 172ПИ. Вариант 44

using System;
using CommonWorkingLibrary;

namespace SweetLibrary
{
    public class IceCream : Sweets // Производный класс "Мороженое"
    {
        private string _date; // Дата изготовления
        private string _taste; // Вкус

        public IceCream()
        {
            _date = String.Empty;
            _taste = String.Empty;
        }

        public string Taste
        {
            get { return _taste; }
            set
            {
                if (value.Length > 200)
                    throw new Exception(Literals.ExceptionMessages.TasteEx);
                _taste = value;
            }
        }

        public string Date
        {
            get
            {
                return String.IsNullOrWhiteSpace(_date) ? String.Empty : _date;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    _date = String.Empty;
                else
                {
                    DateTime temp;
                    if (!DateTime.TryParse(value, out temp) || value.Length != Literals.Controls.DateFormat.Length)
                        throw new Exception(Literals.ExceptionMessages.CantMakeDate);
                    else
                        _date = temp.ToString(Literals.Controls.DateFormat);
                }
            }
        }

        public override string GetKind
        {
            get { return Literals.Specific.IceCream; }
        }

        //Свойство возвращает true если продукт просрочен и false если нет или невозможно проверить
        public override bool IsOverdue
        {
            get 
            { 
                if (String.IsNullOrWhiteSpace(Date) || ShelfLife == 0)
                    return false;
                

                int y = DateTime.Today.Year - int.Parse(Date.Substring(3));
                int m = Math.Abs(DateTime.Today.Month - int.Parse(Date.Substring(0,2)));
                m = Math.Abs((y * 12) - m);
                if (m >= ShelfLife)
                    return true;

                else return false;
            }
        }

        public override string ToString()
        {
            if (String.IsNullOrWhiteSpace(Name))
                return Literals.Specific.IceCream;
            else
                return String.Format("{0} «{1}»", Literals.Specific.IceCream, Name);
        }
    }
}
