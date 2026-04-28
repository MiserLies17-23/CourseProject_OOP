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

        public async Task AddAsync(SectionEnum section, string name, int age, string description, string dateOfDiscovery)
        {
            await _exhibitService.AddAsync(section, name, age, description, dateOfDiscovery);
        }

        public async Task UpdateAsync(int exhibitId, SectionEnum section, string name, int age, string dateOfDiscovery, string description)
        {
            await _exhibitService.UpdateAsync(exhibitId, section, name, age, dateOfDiscovery, description);
        }

        public async Task DeleteAsync(int exhibitId)
        {
            await _exhibitService.DeleteAsync(exhibitId);
        }

        public async Task DeleteAllBySectionAsync(SectionEnum section)
        {
            await _exhibitService.DeleteAllBySectionAsync(section);
        }
    }
}
