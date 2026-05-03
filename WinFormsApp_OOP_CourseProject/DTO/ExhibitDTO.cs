using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.DTO
{
    /// <summary>
    /// DTO для передачи данных об экспонате между слоями приложения
    /// Используется для передачи на данных о модели на форму
    /// </summary>
    public class ExhibitDTO
    {
        /// <summary>
        /// Уникальный идентификатор экспоната
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Раздел музея
        /// </summary>
        public SectionEnum Section { get; set; }

        /// <summary>
        /// Название экспоната
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Возраст экспоната (в годах)
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Дата обнаружения в формате строки
        /// </summary>
        public string? DateOfDiscovery { get; set; }

        /// <summary>
        /// Описание экспоната
        /// </summary>
        public string? Description { get; set; }
    }
}
