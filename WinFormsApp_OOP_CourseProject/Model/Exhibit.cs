namespace WinFormsApp_OOP_CourseProject.Model
{
    /// <summary>
    /// Сущность "Экспонат" - основная модель данных для работы с музейными экспонатами
    /// </summary>
    public class Exhibit
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
        /// Дата обнаружения или создания экспоната
        /// </summary>
        public DateTime DateOfDiscovery { get; set; }

        /// <summary>
        /// Описание экспоната
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Конструктор по умолчанию. Создаёт экспонат с заполнителями
        /// </summary>
        public Exhibit()
        {
            Section = SectionEnum.Archaeological;
            Name = "Неизвестно";
            Age = 0;
            DateOfDiscovery = DateTime.Now;
            Description = "...";
        }

        /// <summary>
        /// Конструктор с параметрами для создания полноценного экспоната
        /// </summary>
        /// <param name="section"> Раздел музея </param>
        /// <param name="name"> Название экспоната </param>
        /// <param name="age"> Возраст экспоната </param>
        /// <param name="dateOfDiscovery"> Дата обнаружения </param>
        /// <param name="description"> Описание </param>
        public Exhibit(SectionEnum section, string name, int age, DateTime dateOfDiscovery, string description)
        {
            Section = section;
            Name = name;
            Age = age;
            DateOfDiscovery = dateOfDiscovery;
            Description = description;
        }
    }
}
