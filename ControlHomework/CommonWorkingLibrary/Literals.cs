
/*
 * Данный статический класс содержит все строковые константы, используемые в форме и выходном файле.
 * Появился он в результате того, что первый вариант программы был полностью "захардкоден" на английском языке, 
 * но затем мне пришлось все это переводить и искать в коде литералы, что довольно утомительно. 
 * Поэтому было решено расхардкодить строковые константы путем создания данного класса.
*/

using System;

namespace CommonWorkingLibrary
{
    public static class Literals
    {
        public const string ProgramName = "Control Home Work v.44";
        public const string About = "НИУ «Высшая школа экономики». \nФакультет бизнес-информатики. Отделение программной инженерии.\n3-й модуль. Контрольное домашнее задание. Вариант 44.\nСтудент: Трофимов Илья. Группа: 172ПИ. 2013 год.";

        public static class Specific
        {
            public const string Sweet = "Сладость",
                                Sweets = "Сладости",
                                IceCream = "Мороженое",
                                DriedApricots = "Курага",   
                                Name = "Наименование",
                                Country = "Страна производитель",
                                Cost = "Стоимость (руб/кг)",
                                MinTemperature = "Мин. температура хранения",
                                MaxTemperature = "Макс. температура хранения",
                                ShelfLife = "Срок годности (мес.)",
                                Calories = "Энергетическая ценность (ккал/100г)",
                                Date = "Дата изготовления (мм.гггг)",
                                Sort = "Сорт кураги",
                                Taste = "Вкус",
                                Separator = "**";

            public static readonly string[] ParametersArray = { Name, Country, Cost, MinTemperature, MaxTemperature, ShelfLife, Calories, Date };

            public static string Title(string kind)
            {
                return String.Format("=={0}==", kind);
            }
        }

        public static class Controls
        {
            public const string File = "Файл",
                                Edit = "Редактировать",
                                Help = "Справка",
                                Create = "Создать",
                                Open = "Открыть",
                                Close = "Закрыть",
                                Save = "Сохранить",
                                SaveAs = "Сохранить как",
                                Import = "Импортировать",
                                Export = "Экспортировать",
                                Exit = "Выход",
                                AddItem = "Добавить элемент",
                                RemoveSelected = "Удалить выделенное",
                                OverDue = "Удалить просроченные продукты",
                                TitleList = "Список сладостей",
                                TitlePropertes = "Свойства",
                                Error = "Ошибка",
                                NoName = "Безымянный",
                                Filter = "Текстовый файл (*.txt)|*.txt",
                                DateFormat = "MM.yyyy";

            // метод возвращает стркоу - заголовок программы
            public static string ProgramTitle(string fileName)
            {
                if (String.IsNullOrWhiteSpace(fileName))
                    fileName = NoName;
                else if (fileName.LastIndexOf('\\') != -1)
                    fileName = fileName.Substring(fileName.LastIndexOf('\\') + 1, fileName.LastIndexOf('.') - fileName.LastIndexOf('\\') - 1);
                return String.Format("{0} - {1}", ProgramName, fileName);
            }

            // метод возвращает стркоу - вопрос об сохранении перед выходом
            public static string ClosingQuestion(string fileName)
            {
                if (String.IsNullOrWhiteSpace(fileName))
                    fileName = NoName + ".txt";
                else if (fileName.LastIndexOf('\\') != -1)
                    fileName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
                return String.Format("Файл {0} был изменен.\nСохранить изминения перед закрытием?", fileName);
            }
        }

        public static class ToolTips
        {
            public const string Create = "Создать новый список.",
                                Open = "Открыть список из текстового файла.",
                                Close = "Закрыть текущий список.",
                                Save = "Сохранить текущий список в текстовый файл.",
                                SaveAs = "Сохранить текущий список в новый текстовый файл.",
                                Import = "Добавить данные из уже существующего текстового файла к текущему списку.",
                                Export = "Добавить данные из текущего списка к уже существующему текстовому файлу.",
                                Exit = "Выйти из программы.",
                                AddIceCream = "Добавить мороженое в текущий список.",
                                AddDriedApricots = "Добавить курагу в текущий список.",
                                RemoveSelected = "Удалить выделенные элементы из списка.";
        }

        public static class ExceptionMessages
        {
            public const string OpenFileError = "Произошла ошибка при открытии файла.\nВозможно не все данные с файла считались корректно.",
                                NameLength = "Название продукта слишком большое.",
                                ContryLength = "Название страны слишком большое.",
                                CountryName = "Название страны содержит недопустимые символы.",
                                MinTlow = "Минимальная температура хранения не может быть ниже -100 градусов.",
                                MinThigh = "Минимальная температура хранения не может быть выше 100 градусов.",
                                MaxTlow = "Максимальная температура хранения не может быть ниже -100 градусов.",
                                MaxThigh = "Максимальная температура хранения не может быть выше 100 градусов.",
                                MinMax = "Минимальная температура хранения не может быть выше максимальной.",
                                MaxMin = "Максимальная температура хранения не может быть ниже минимальной.",
                                CostEx = "Стоимость не может быть меньше нуля.",
                                ShelfLifeEx = "Срок годности не может быть больше 120 месяцев (10 лет).",
                                CaloriesLessZero = "Энергетическая ценность не может быть меньше нуля.",
                                TasteEx = "Поле вкус не может содержать более 200 символов.",
                                SortEx = "Поле сорт не может содержать более 200 символов.",
                                CantMakeDate = "Неверный формат задания даты.\nВведите дату в формате мм.гггг (например: 02.2013).";
        }
    }
}