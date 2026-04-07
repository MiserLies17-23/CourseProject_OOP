using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Service;

namespace WinFormsApp_OOP_CourseProject.Controller
{
    public class ExhibitController
    {
        private readonly ExhibitService _exhibitService;

        public ExhibitController()
        {
            _exhibitService = new ExhibitService();
        }

        public List<ExhibitDTO> GetAll()
        {
            var exhibits = _exhibitService.GetAll()
                ?? throw new ArgumentException("Репозиторий пуст!");

            return exhibits.Select(exhibit => new ExhibitDTO
            {
                Id = exhibit.Id,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        public List<ExhibitDTO> GetBySection(SectionEnum section)
        {
            var exhibits = _exhibitService.GetBySection(section)
                ?? throw new ArgumentException("Список секции пуст!");

            return exhibits.Select(exhibit => new ExhibitDTO
            {
                Id = exhibit.Id,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        public ExhibitDTO GetById(int exhibitId)
        {
            var exhibit = _exhibitService.GetById(exhibitId);
            return new ExhibitDTO
            {
                Id = exhibit.Id,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            };
        }

        public void Add(SectionEnum section, string name, int age, string description, string dateOfDiscovery)
        {
            //Добавить проверку на корректность строки!
            if (!DateTime.TryParse(dateOfDiscovery, out var dateOfDiscoveryDateTime))
                throw new ArgumentException("Неправильный формат даты!");

            //Валидация остальных параметров...

            _exhibitService.Add(section, name, age, description, dateOfDiscoveryDateTime);
        }

        public void Edit(int exhibitId, SectionEnum section, string name, int age, string dateOfDiscovery, string description)
        {
            if (!DateTime.TryParse(dateOfDiscovery, out var dateOfDiscoveryDateTime))
                throw new ArgumentException("Неправильный формат даты!");

            _exhibitService.Edit(exhibitId, section, name, age, dateOfDiscoveryDateTime, description);
        }

        public void Delete(int exhibitId)
        {
            _exhibitService.Delete(exhibitId);
        }
    }
}
