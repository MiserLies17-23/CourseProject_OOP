using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Utils
{
    /// <summary>
    /// Статический класс-расширение для работы с перечислением SectionEnum.
    /// Предоставляет методы для отображения названий разделов
    /// </summary>
    public static class MuseumSectionExtension
    {
        /// <summary>
        /// Возвращает отображаемое имя раздела на русском языке
        /// </summary>
        /// <param name="section"> Раздел музея </param>
        /// <returns> Строковое представление раздела для отображения пользователю </returns>
        /// <exception cref="NotImplementedException"> Выбрасывается, если передан неизвестный раздел </exception>
        public static string GetDisplayName(SectionEnum section)
        {
            return section switch
            {
                SectionEnum.Archaeological => "Археология",
                SectionEnum.Ethnographic => "Этнография",
                _ => throw new NotImplementedException()
            };
        }
    }
}
