using System.Text.RegularExpressions;

namespace WinFormsApp_OOP_CourseProject.Utils
{
    public static class Validator
    {
        /// <summary>
        /// Валидация имени экспоната
        /// </summary>
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя экспоната не может быть пустым");

            if (name.Length < 2)
                throw new ArgumentException("Имя экспоната должно содержать минимум 2 символа");

            if (name.Length > 100)
                throw new ArgumentException("Имя экспоната не может превышать 100 символов");

            if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ0-9\s\-.,!?()]+$"))
                throw new ArgumentException("Имя содержит недопустимые символы");
        }

        /// <summary>
        /// Валидация возраста экспоната
        /// </summary>
        public static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");

            if (age > 10000)
                throw new ArgumentException("Возраст не может превышать 10000 лет");
        }

        /// <summary>
        /// Валидация описания экспоната
        /// </summary>
        public static void ValidateDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Описание не может быть пустым");

            if (description.Length < 10)
                throw new ArgumentException("Описание должно содержать минимум 10 символов");

            if (description.Length > 1000)
                throw new ArgumentException("Описание не может превышать 1000 символов");
        }

        /// <summary>
        /// Валидация даты открытия
        /// </summary>
        public static DateTime ValidateDate(string dateText)
        {
            if (string.IsNullOrWhiteSpace(dateText))
                throw new ArgumentException("Дата открытия не может быть пустой");

            string[] formats = { "dd/MM/yyyy", "dd.MM.yyyy", "yyyy-MM-dd", "dd-MM-yyyy" };
            if (!DateTime.TryParseExact(dateText, formats,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                throw new ArgumentException("Неверный формат даты. Используйте: ДД/ММ/ГГГГ");
            }

            if (date > DateTime.Now)
                throw new ArgumentException("Дата открытия не может быть в будущем");

            if (date.Year < 1000)
                throw new ArgumentException("Год открытия не может быть ранее 1000 года");

            return date;
        }

        /// <summary>
        /// Полная валидация всех полей экспоната
        /// </summary>
        public static void ValidateExhibit(string name, int age, string description, string dateText, out DateTime date)
        {
            ValidateName(name);
            ValidateAge(age);
            ValidateDescription(description);
            date = ValidateDate(dateText);
        }
    }
}
