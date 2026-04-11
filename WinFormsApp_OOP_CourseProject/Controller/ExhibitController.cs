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
                Section = exhibit.Section,
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
                Section = exhibit.Section,
                Name = exhibit.Name,
                Age = exhibit.Age,
                DateOfDiscovery = exhibit.DateOfDiscovery.ToString("dd/MM/yyyy"),
                Description = exhibit.Description
            }).ToList();
        }

        public ExhibitDTO GetById(int exhibitId)
        {
            var exhibit = _exhibitService.GetById(exhibitId)
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

        public void Add(SectionEnum section, string name, int age, string description, string dateOfDiscovery)
        {
            _exhibitService.Add(section, name, age, description, dateOfDiscovery);
        }

        public void Edit(int exhibitId, SectionEnum section, string name, int age, string dateOfDiscovery, string description)
        {
            _exhibitService.Edit(exhibitId, section, name, age, dateOfDiscovery, description);
        }

        public void Delete(int exhibitId)
        {
            _exhibitService.Delete(exhibitId);
        }
    }
}
