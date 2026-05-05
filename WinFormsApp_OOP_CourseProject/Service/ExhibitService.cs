using System.Diagnostics;
using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Repository;
using WinFormsApp_OOP_CourseProject.Utils;

namespace WinFormsApp_OOP_CourseProject.Service
{
    /// <summary>
    /// Класс, представляющий сервис работы с моделью.
    /// Основной слой бизнес-логика
    /// </summary>
    public class ExhibitService
    {
        /// <summary> Объект репозитория для работы с объектами модели </summary>
        private readonly ExhibitRepository _exhibitRepository;

        /// <summary>
        /// Конструкор по умолчанию
        /// </summary>
        public ExhibitService()
        {
            _exhibitRepository = new ExhibitRepository();
        }

        /// <summary>
        /// Асинхронный метод для добавления нового объекта
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <param name="name"> Название </param>
        /// <param name="age"> Возраст </param>
        /// <param name="description"> Описание </param>
        /// <param name="dateOfDiscovery"> Дата открытия </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        /// <exception cref="ArgumentException"> Выбрасываетеся, если экспонат с указанным названием уже существует </exception>
        public async Task AddAsync(SectionEnum section, string name, int age, string description, string dateOfDiscovery)
        {
            Validator.ValidateExhibit(name, age, description,
               dateOfDiscovery, out DateTime date);

            var exhibits = await _exhibitRepository.GetByNameAsync(name);
            if (exhibits.Any())
                throw new ArgumentException("Экспонат с таким именем уже существует!");

            var newExhibit = new Exhibit(section, name, age, date, description);

            await _exhibitRepository.AddAsync(newExhibit);
        }

        /// <summary>
        /// Асинхронный метод для получения всех объектов репозитория
        /// </summary>
        /// <returns> Результат задачи: перечисляемая коллекия всех объектов репозитория </returns>
        public async Task<IEnumerable<Exhibit>> GetAllAsync()
        {
            return await _exhibitRepository.GetAllAsync();
        }

        /// <summary>
        /// Асинхронный метод для получения всех объектов репозитория по названию секции
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <returns> Результат задачи: перечисляемая коллекия объектов указанной секции </returns>
        public async Task<IEnumerable<Exhibit>> GetBySectionAsync(SectionEnum section)
        {
            return await _exhibitRepository.GetBySectionAsync(section);
        }

        /// <summary>
        /// Асинхронный метод для получения объекта по id
        /// </summary>
        /// <param name="id"> id объекта </param>
        /// <returns> Результат задачи: объект с указанным id </returns>
        public async Task<Exhibit> GetByIdAsync(int id)
        {
            if (id < 0)
                throw new ArgumentException("Id не может быть отрицательным!");

            var exhibit = await _exhibitRepository.GetByIdAsync(id);

            if (exhibit == null)
                throw new ArgumentException($"Экспонат с id = {id} не найден!");

            return exhibit;
        }

        /// <summary>
        /// Асинхронный метод для получения всех объектов с совпадением по названиям
        /// </summary>
        /// <param name="name"> Название </param>
        /// <returns> Результат задачи: перечисляемая коллекция объектов с совпадением по названиям </returns>
        public async Task<IEnumerable<Exhibit>> GetByNameAsync(string name)
        {
            return await _exhibitRepository.GetByNameAsync(name);
        }

        /// <summary>
        /// Асинхронный метод для получения объектов с совпадением по возрастам
        /// </summary>
        /// <param name="age"> Возраст </param>
        /// <returns> Результат задачи: перечисляемая коллекция объектов с совпадением по возрастам </returns>
        public async Task<IEnumerable<Exhibit>> GetByAgeAsync(int age)
        {
            Validator.ValidateAge(age);

            return await _exhibitRepository.GetByAgeAsync(age);
        }

        /// <summary>
        /// Асинхронный метод для получения объектов по дате открытия
        /// </summary>
        /// <param name="date"> Дата открытия </param>
        /// <returns> Результат задачи: перечисляемая коллекция экспонатов по дате открытия </returns>
        public async Task<IEnumerable<Exhibit>> GetByDateAsync(string date)
        {
            DateTime currentDate = Validator.ValidateDate(date);

            Debug.WriteLine(currentDate);

            return await _exhibitRepository.GetByDateAsync(currentDate);
        }

        /// <summary>
        /// Асинхронный метод для обновления свойств объекта
        /// </summary>
        /// <param name="id"> id объекта </param>
        /// <param name="newSection"> Новая секция </param>
        /// <param name="newName"> Новое название </param>
        /// <param name="newAge"> Новый возраст </param>
        /// <param name="newDateOfDiscovery"> Новая дата открытия </param>
        /// <param name="newDescription"> Новое описание </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        /// <exception cref="ArgumentException"> Выбрасывается, если указан неверный id </exception>
        public async Task UpdateAsync(int id, SectionEnum newSection, string newName, int newAge, 
            string newDateOfDiscovery, string newDescription)
        {
            if (id < 0)
                throw new ArgumentException("Указан неверный Id!");

            var editExhibit = await _exhibitRepository.GetByIdAsync(id);
            
            Validator.ValidateExhibit(newName, newAge, newDescription, 
               newDateOfDiscovery, out DateTime date);

            editExhibit!.Section = newSection;
            editExhibit!.Name = newName;
            editExhibit!.Age = newAge;
            editExhibit!.DateOfDiscovery = date;
            editExhibit!.Description = newDescription;

            await _exhibitRepository.UpdateAsync(editExhibit!);
        }

        /// <summary>
        /// Асинхронный метод для удаления объекта по id
        /// </summary>
        /// <param name="id"> id объекта </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        /// <exception cref="ArgumentException"> Выбрасывается, если указан неверный id </exception>
        public async Task DeleteAsync(int id)
        {
            if (id < 0)
                throw new ArgumentException("Id не может быть отрицательным!");

            var exhibit = await _exhibitRepository.GetByIdAsync(id);
            if (exhibit == null)
                throw new ArgumentException($"Экспонат с id = {id} не найден!");

            await _exhibitRepository.DeleteAsync(id);
        }

        /// <summary>
        /// Асинхронный метод для удаления всех экспонатов указанной секции
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <returns> Задача, представляющая асинхронную операцию </returns>
        public async Task DeleteAllBySectionAsync(SectionEnum section)
        {
            await _exhibitRepository.DeleteAllBySectionAsync(section);
        }
    }
}
