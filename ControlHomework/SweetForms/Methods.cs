// Трофимов Илья. Группа 172ПИ. Вариант 44

using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using CommonWorkingLibrary;
using SweetLibrary;

namespace SweetForms
{
    public static class Methods
    {
        private static int padRightValue = MaxLength(Literals.Specific.ParametersArray) + 6;

        private static int MaxLength(string[] array)
        {
            int i = 0;
            foreach (var str in array)
                if (str.Length > i)
                    i = str.Length;
            return i;
        }

        // Необходим что бы обновить данные в listbox
        public static void RefreshListBox(ListBox listbox, List<Sweets> list)
        {
            listbox.DataSource = null;
            listbox.DataSource = list;
        }
        
        // Сохранение в файл
        public static void Save(string path, List<Sweets> list, bool isItExport)
        {
            StreamWriter writer = new StreamWriter(path, isItExport, Encoding.Unicode);

            foreach (var item in list)
            {
                writer.WriteLine(Literals.Specific.Title(item.GetKind));
                writer.WriteLine(Literals.Specific.Separator);

                // Проверяем если значения свойств не являются их нулевыми значениями, то делаем вывод данного значения 
                
                if (!String.IsNullOrWhiteSpace(item.Name))
                    writer.WriteLine((Literals.Specific.Name + ':').PadRight(padRightValue) + item.Name);

                if (!String.IsNullOrWhiteSpace(item.Country))
                    writer.WriteLine((Literals.Specific.Country + ':').PadRight(padRightValue) + item.Country);

                if(item.Cost > 0)
                    writer.WriteLine((Literals.Specific.Cost + ':').PadRight(padRightValue) + item.Cost.ToString("f2"));

                if(item.MinTemperature > -101)
                    writer.WriteLine((Literals.Specific.MinTemperature + ':').PadRight(padRightValue) + item.MinTemperature);

                if (item.MaxTemperature < 101)
                    writer.WriteLine((Literals.Specific.MaxTemperature + ':').PadRight(padRightValue) + item.MaxTemperature);                    

                if(item.Calories > -1)
                    writer.WriteLine((Literals.Specific.Calories + ':').PadRight(padRightValue) + item.Calories);

                if (item.ShelfLife != 0)
                    writer.WriteLine((Literals.Specific.ShelfLife + ':').PadRight(padRightValue) + item.ShelfLife);

                if (item is IceCream && !String.IsNullOrWhiteSpace(((IceCream)item).Date))
                    writer.WriteLine((Literals.Specific.Date + ':').PadRight(padRightValue) + ((IceCream)item).Date);

                if (item is DriedApricots && !String.IsNullOrWhiteSpace(((DriedApricots)item).Date))
                    writer.WriteLine((Literals.Specific.Date + ':').PadRight(padRightValue) + ((DriedApricots)item).Date);

                if (item is IceCream && !String.IsNullOrWhiteSpace(((IceCream)item).Taste))
                    writer.WriteLine((Literals.Specific.Taste + ':').PadRight(padRightValue) + ((IceCream)item).Taste);

                if (item is DriedApricots && !String.IsNullOrWhiteSpace(((DriedApricots)item).Sort))
                    writer.WriteLine((Literals.Specific.Sort + ':').PadRight(padRightValue) + ((DriedApricots)item).Sort);

                writer.WriteLine();
            }

            writer.Flush();
            writer.Close();
        }

        // Открытие файла
        public static void Open(string path, List<Sweets> list, bool isItImport)
        {
            StreamReader reader = new StreamReader(path, Encoding.Unicode);
            int i;
            bool everythingIsOk = true;
                 
            if (isItImport)
                i = list.Count - 1;
            
            else
            {
                list.Clear();
                i = -1;
            }

            while (true)
            {
                string currentLine = reader.ReadLine();
                 
                if (currentLine == null) break;

                else if (currentLine.Contains(Literals.Specific.Title(Literals.Specific.IceCream)))
                {
                    list.Add(new IceCream());
                    i++;
                }

                else if (currentLine.Contains(Literals.Specific.Title(Literals.Specific.DriedApricots)))
                {
                    list.Add(new DriedApricots());
                    i++;
                }

                else if (i != -1)
                    try
                    {
                        // Проверяем считываемую строку на наличие данного литерала, если она содержит этот литерал, то парсим строку

                        if (currentLine.Contains(Literals.Specific.Name + ':'))
                            list[i].Name = currentLine.Substring(currentLine.IndexOf(':') + 1).Trim();

                        else if (currentLine.Contains(Literals.Specific.Country + ':'))
                            list[i].Country = currentLine.Substring(currentLine.IndexOf(':') + 1).Trim();

                        else if (currentLine.Contains(Literals.Specific.Cost + ':'))
                            list[i].Cost = double.Parse(currentLine.Substring(currentLine.IndexOf(':') + 1).Trim());

                        else if (currentLine.Contains(Literals.Specific.MinTemperature + ':'))
                        {
                            int checkTemp = int.Parse(currentLine.Substring(currentLine.IndexOf(':') + 1).Trim());
                            if (checkTemp > -101)
                                list[i].MinTemperature = checkTemp;
                            else everythingIsOk = false;
                        }

                        else if (currentLine.Contains(Literals.Specific.MaxTemperature + ':'))
                        {
                            int checkTemp = int.Parse(currentLine.Substring(currentLine.IndexOf(':') + 1).Trim());
                            if (checkTemp < 101)
                                list[i].MaxTemperature = checkTemp;
                            else everythingIsOk = false;
                        }

                        else if (currentLine.Contains(Literals.Specific.Calories + ':'))
                        {
                            int checkTemp = int.Parse(currentLine.Substring(currentLine.IndexOf(':') + 1).Trim());
                            if (checkTemp > -1)
                                list[i].Calories = checkTemp;
                            else everythingIsOk = false;
                        }

                        else if (currentLine.Contains(Literals.Specific.ShelfLife + ':'))
                            list[i].ShelfLife = uint.Parse(currentLine.Substring(currentLine.IndexOf(':') + 1).Trim());

                        else if (currentLine.Contains(Literals.Specific.Date + ':'))
                        {
                            if (list[i] is IceCream)
                                ((IceCream)list[i]).Date = currentLine.Substring(currentLine.IndexOf(':') + 1).Trim();
                            else if (list[i] is DriedApricots)
                                ((DriedApricots)list[i]).Date = currentLine.Substring(currentLine.IndexOf(':') + 1).Trim();
                        }

                        else if (currentLine.Contains(Literals.Specific.Taste + ':'))
                            ((IceCream)list[i]).Taste = currentLine.Substring(currentLine.IndexOf(':') + 1).Trim();

                        else if (currentLine.Contains(Literals.Specific.Sort + ':'))
                            ((DriedApricots)list[i]).Sort = currentLine.Substring(currentLine.IndexOf(':') + 1).Trim();
                    }
                    catch { everythingIsOk = false; }
            }

            reader.Close();
            if (!everythingIsOk)
                MessageBox.Show(Literals.ExceptionMessages.OpenFileError, Literals.Controls.Error, MessageBoxButtons.OK);
        }
    }
}