using Dapper;
using Npgsql;
using WinFormsApp_OOP_CourseProject.Config;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Repository
{
    /// <summary>
    /// Класс репозитория экспонатов.
    /// Наследует методы интерфейса IExhibitRepository
    /// </summary>
    public class ExhibitRepository : IExhibitRepository
    {
        /// <summary> Строка подключения к бд </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ExhibitRepository()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        /// <summary>
        /// Подулючение к бд
        /// </summary>
        /// <returns> Параметр соединения с бд </returns>
        private NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        /// <summary>
        /// Асинхронный метод для получения всех объектов репозитория
        /// </summary>
        /// <returns> Результат задачи: перечисляемая коллекия всех объектов репозитория </returns>
        public async Task<IEnumerable<Exhibit>> GetAllAsync()
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits";
            return await connection.QueryAsync<Exhibit>(sql);
        }

        /// <summary>
        /// Асинхронный метод для получения всех объектов репозитория по названию секции
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <returns> Результат задачи: перечисляемая коллекия объектов указанной секции </returns>
        public async Task<IEnumerable<Exhibit>> GetBySectionAsync(SectionEnum section)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Section = @Section";
            return await connection.QueryAsync<Exhibit>(sql, new { Section = section.ToString() });
        }

        /// <summary>
        /// Асинхронный метод для получения объекта по id
        /// </summary>
        /// <param name="exhibitId"> id объекта </param>
        /// <returns> Результат задачи: объект с указанным id </returns>
        public async Task<Exhibit?> GetByIdAsync(int exhibitId)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Id = @Id";
            return await connection.QueryFirstOrDefaultAsync<Exhibit>(sql, new { Id = exhibitId });
        }

        /// <summary>
        /// Асинхронный метод для получения всех объектов с совпадением по названиям
        /// </summary>
        /// <param name="name"> Название </param>
        /// <returns> Результат задачи: перечисляемая коллекция объектов с совпадением по названиям </returns>
        public async Task<IEnumerable<Exhibit>> GetByNameAsync(string name)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Name LIKE @Name";
            return await connection.QueryAsync<Exhibit>(sql, new { Name = $"%{name}%" });
        }

        /// <summary>
        /// Асинхронный метод для получения объектов с совпадением по возрастам
        /// </summary>
        /// <param name="age"> Возраст </param>
        /// <returns> Результат задачи: перечисляемая коллекция объектов с совпадением по возрастам </returns>
        public async Task<IEnumerable<Exhibit>> GetByAgeAsync(int age)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Age = @Age";
            return await connection.QueryAsync<Exhibit>(sql, new { Age = age });
        }

        /// <summary>
        /// Асинхронный метод для получения объектов по дате открытия
        /// </summary>
        /// <param name="date"> Дата открытия </param>
        /// <returns> Результат задачи: перечисляемая коллекция экспонатов по дате открытия </returns>
        public async Task<IEnumerable<Exhibit>> GetByDateAsync(DateTime date)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE DateOfDiscovery = @DateOfDiscovery";
            return await connection.QueryAsync<Exhibit>(sql, new { DateTime = date });
        }

        /// <summary>
        /// Асинхронный метод для добавления нового объекта
        /// </summary>
        /// <param name="newExhibit"> Новый объект </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        public async Task AddAsync(Exhibit newExhibit)
        {
            var connection = CreateConnection();
            var sql = @"
            INSERT INTO Exhibits (Name, Description, Section, Age, DateOfDiscovery)
            VALUES (@Name, @Description, @Section, @Age, @DateOfDiscovery)
            RETURNING Id";

            newExhibit.Id = await connection.QuerySingleAsync<int>(sql, new
            {
                newExhibit.Name,
                newExhibit.Description,
                Section = newExhibit.Section.ToString(),
                newExhibit.Age,
                newExhibit.DateOfDiscovery
            });
        }

        /// <summary>
        /// Асинхронный метод для обновления свойств объекта
        /// </summary>
        /// <param name="editExhibit"> Изменяемый объект </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        public async Task UpdateAsync(Exhibit editExhibit)
        {
            var connection = CreateConnection();
            var sql = @"
            UPDATE Exhibits 
            SET Name = @Name, 
                Description = @Description, 
                Section = @Section,
                Age = @Age,
                DateOfDiscovery = @DateOfDiscovery
            WHERE Id = @Id";

            await connection.ExecuteAsync(sql, new
            {
                editExhibit.Id,
                editExhibit.Name,
                editExhibit.Description,
                Section = editExhibit.Section.ToString(),
                editExhibit.Age,
                editExhibit.DateOfDiscovery
            });
        }

        /// <summary>
        /// Асинхронный метод для удаления объекта по id
        /// </summary>
        /// <param name="exhibitId"> id объекта </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        public async Task DeleteAsync(int exhibitId)
        {
            using var connection = CreateConnection();
            var sql = "DELETE FROM Exhibits WHERE Id = @Id";
            await connection.ExecuteAsync(sql, new { Id = exhibitId });
        }

        /// <summary>
        /// Асинхронный метод для удаления всех экспонатов указанной секции
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        public async Task DeleteAllBySectionAsync(SectionEnum section)
        {
            var exhibits = (IEnumerable<Exhibit>)GetBySectionAsync(section);
            foreach(var exhib in exhibits)
            { 
                await DeleteAsync(exhib.Id); 
            }
        }
    }
}
