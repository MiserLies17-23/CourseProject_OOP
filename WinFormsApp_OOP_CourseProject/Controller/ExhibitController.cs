using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Service;

namespace WinFormsApp_OOP_CourseProject.Controller
{
    /// <summary>
    /// Контроллер для управления экспонатами.
    /// Обрабатывает запросы и преобразует модели в DTO
    /// </summary>
    public class ExhibitController
    {
        private readonly ExhibitService _exhibitService;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ExhibitController()
        {
            _exhibitService = new ExhibitService();
        }

        /// <summary>
        /// Возвращает список всех экспонатов
        /// </summary>
        /// <returns> Результат задачи: список DTO всех экспонатов </returns>
        /// <exception cref="ArgumentException"> Выбрасывается, если репозиторий пуст </exception>
        public async Task<List<ExhibitDTO>> GetAllAsync()
        {
            var exhibits = await _exhibitService.GetAllAsync()
                ?? throw new ArgumentException("Репозиторий пуст!");

            return exhibits.Select(exhibit => new ExhibitDTO
            {
                Id = exhibit.Id,
                Section = exhibit.Section,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        /// <summary>
        /// Возвращает список экспонатов по указанной секции
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <returns> Результат задачи: список DTO экспонатов из указанной секции </returns>
        /// <exception cref="ArgumentException"> Выбрасывается, если список секции пуст </exception>
        public async Task<List<ExhibitDTO>> GetBySectionAsync(SectionEnum section)
        {
            var exhibits = await _exhibitService.GetBySectionAsync(section)
                ?? throw new ArgumentException("Список секции пуст!");

            return exhibits.Select(exhibit => new ExhibitDTO
            {
                Id = exhibit.Id,
                Section = exhibit.Section,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        /// <summary>
        /// Возвращает экспонат по его id
        /// </summary>
        /// <param name="exhibitId"> id экспоната </param>
        /// <returns> Результат задачи: DTO найденного экспоната </returns>
        /// <exception cref="ArgumentNullException"> Выбрасывается, если экспонат не найден </exception>
        public async Task<ExhibitDTO> GetByIdAsync(int exhibitId)
        {
            var exhibit = await _exhibitService.GetByIdAsync(exhibitId)
                ?? throw new ArgumentNullException("Ошибка поиска экспоната");

            return new ExhibitDTO
            {
                Id = exhibit.Id,
                Section = exhibit.Section,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            };
        }

        /// <summary>
        /// Возвращает список экспонатов c совпадением по названиям
        /// </summary>
        /// <param name="name"> Название экспоната </param>
        /// <returns> Результат задачи: список DTO экспонатов с указанным названием </returns>
        /// <exception cref="ArgumentNullException"> Выбрасывается, если экспонаты не найдены </exception>
        public async Task<List<ExhibitDTO>> GetByNameAsync(string name)
        {
            var exhibits = await _exhibitService.GetByNameAsync(name)
                ?? throw new ArgumentNullException("Ошибка поиска экспоната");

            return exhibits.Select(exhibit => new ExhibitDTO
            {
                Id = exhibit.Id,
                Section = exhibit.Section,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        /// <summary>
        /// Возвращает список экспонатов с указанным возрастом 
        /// </summary>
        /// <param name="age"> Возраст экспоната в годах </param>
        /// <returns> Результат задачи: список DTO экспонатов с указанным возрастом </returns>
        /// <exception cref="ArgumentNullException" >Выбрасывается, если экспонаты не найдены </exception>
        public async Task<List<ExhibitDTO>> GetByAgeAsync(int age)
        {
            var exhibits = await _exhibitService.GetByAgeAsync(age)
                ?? throw new ArgumentNullException("Ошибка поиска экспоната");

            return exhibits.Select(exhibit => new ExhibitDTO
            {
                Id = exhibit.Id,
                Section = exhibit.Section,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        /// <summary>
        /// Возвращает список экспонатов по дате обнаружения
        /// </summary>
        /// <param name="stringDate"> Дата в формате строки </param>
        /// <returns> Результат задачи: список DTO экспонатов, найденных в указанную дату </returns>
        /// <exception cref="ArgumentNullException"> Выбрасывается, если экспонаты не найдены </exception>
        public async Task<List<ExhibitDTO>> GetByDateAsync(string stringDate)
        {
            var exhibits = await _exhibitService.GetByDateAsync(stringDate)
                ?? throw new ArgumentNullException("Ошибка поиска экспоната");

            return exhibits.Select(exhibit => new ExhibitDTO
            {
                Id = exhibit.Id,
                Section = exhibit.Section,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        /// <summary>
        /// Добавляет новый экспонат
        /// </summary>
        /// <param name="section"> Секция </param>
        /// <param name="name"> Название </param>
        /// <param name="age"> Возраст </param>
        /// <param name="description"> Описание </param>
        /// <param name="dateOfDiscovery"> Дата обнаружения в формате строки </param>
        /// <returns> Задача, представляющая асинхронную операцию добавления </returns>
        public async Task AddAsync(SectionEnum section, string name, int age, string description, string dateOfDiscovery)
        {
            await _exhibitService.AddAsync(section, name, age, description, dateOfDiscovery);
        }

        /// <summary>
        /// Обновляет существующий экспонат
        /// </summary>
        /// <param name="exhibitId"> id обновляемого экспоната </param>
        /// <param name="section"> Новая секция </param>
        /// <param name="name"> Новое название </param>
        /// <param name="age"> Новый возраст </param>
        /// <param name="dateOfDiscovery"> Новая дата обнаружения в формате строки </param>
        /// <param name="description"> Новое описание </param>
        /// <returns> Задача, представляющая асинхронную операцию обновления </returns>
        public async Task UpdateAsync(int exhibitId, SectionEnum section, string name, int age, string dateOfDiscovery, string description)
        {
            await _exhibitService.UpdateAsync(exhibitId, section, name, age, dateOfDiscovery, description);
        }

        /// <summary>
        /// Удаляет экспонат по id
        /// </summary>
        /// <param name="exhibitId"> id удаляемого экспоната </param>
        /// <returns> Задача, представляющая асинхронную операцию удаления </returns>
        public async Task DeleteAsync(int exhibitId)
        {
            await _exhibitService.DeleteAsync(exhibitId);
        }

        /// <summary>
        /// Удаляет все экспонаты из указанной секции
        /// </summary>
        /// <param name="section"> Секция, экспонаты которой будут удалены </param>
        /// <returns> Задача, представляющая асинхронную операцию удаления </returns>
        public async Task DeleteAllBySectionAsync(SectionEnum section)
        {
            await _exhibitService.DeleteAllBySectionAsync(section);
        }
    }
}
