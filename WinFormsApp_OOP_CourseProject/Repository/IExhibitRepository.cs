using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Repository
{
    /// <summary>
    /// Интерфейс репозитория экспонатов
    /// </summary>
    public interface IExhibitRepository
    {
        /// <summary>
        /// Асинхронный метод для получения всех объектов репозитория
        /// </summary>
        /// <returns> Результат задачи: перечисляемая коллекия всех объектов репозитория </returns>
        Task<IEnumerable<Exhibit>> GetAllAsync();

        /// <summary>
        /// Асинхронный метод для получения всех объектов репозитория по названию секции
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <returns> Результат задачи: перечисляемая коллекия объектов указанной секции </returns>
        Task<IEnumerable<Exhibit>> GetBySectionAsync(SectionEnum section);

        /// <summary>
        /// Асинхронный метод для получения объекта по id
        /// </summary>
        /// <param name="exhibitId"> id объекта </param>
        /// <returns> Результат задачи: объект с указанным id </returns>
        Task<Exhibit?> GetByIdAsync(int id);

        /// <summary>
        /// Асинхронный метод для получения всех объектов с совпадением по именам
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <returns> Результат задачи: перечисляемая коллекция объектов с совпадением по именам </returns>
        Task<IEnumerable<Exhibit>> GetByNameAsync(string name);

        /// <summary>
        /// Асинхронный метод для получения объектов по дате открытия
        /// </summary>
        /// <param name="date"> Дата открытия </param>
        /// <returns> Результат задачи: перечисляемая коллекция экспонатов по дате открытия </returns>
        Task<IEnumerable<Exhibit>> GetByDateAsync(DateTime date);

        /// <summary>
        /// Асинхронный метод для получения объектов с совпадением по возрастам
        /// </summary>
        /// <param name="age"> Возраст </param>
        /// <returns> Результат задачи: перечисляемая коллекция объектов с совпадением по возрастам </returns>
        Task<IEnumerable<Exhibit>> GetByAgeAsync(int age);

        /// <summary>
        /// Асинхронный метод для добавления нового объекта
        /// </summary>
        /// <param name="newExhibit"> Новый объект </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        Task AddAsync(Exhibit newExhibit);

        /// <summary>
        /// Асинхронный метод для обновления свойств объекта
        /// </summary>
        /// <param name="editExhibit"> Изменяемый объект </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        Task UpdateAsync(Exhibit editExhibit);

        /// <summary>
        /// Асинхронный метод для удаления объекта по id
        /// </summary>
        /// <param name="id"> id объекта </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        Task DeleteAsync(int id);

        /// <summary>
        /// Асинхронный метод для удаления всех экспонатов указанной секции
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        Task DeleteAllBySectionAsync(SectionEnum section);
    }
}
