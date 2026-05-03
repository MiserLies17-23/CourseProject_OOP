namespace WinFormsApp_OOP_CourseProject.Config
{
    /// <summary>
    /// Статический класс для хранения конфигурации приложения
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// Строка подключения к базе данных PostgreSQL
        /// </summary>
        public static string ConnectionString =>
            "Host=localhost;Port=5432;Database=MuseumDB;Username=postgres;Password=root";
    }

}
