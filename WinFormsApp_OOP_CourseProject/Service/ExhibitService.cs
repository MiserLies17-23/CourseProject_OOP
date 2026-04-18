using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Repository;
using WinFormsApp_OOP_CourseProject.Utils;

namespace WinFormsApp_OOP_CourseProject.Service
{
    public class ExhibitService
    {
        private readonly ExhibitRepository _exhibitRepository;

        public ExhibitService()
        {
            _exhibitRepository = new ExhibitRepository();
        }

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

        public async Task<IEnumerable<Exhibit>> GetAllAsync()
        {
            return await _exhibitRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Exhibit>> GetBySectionAsync(SectionEnum section)
        {
            return await _exhibitRepository.GetBySectionAsync(section);
        }

        public async Task<Exhibit?> GetByIdAsync(int id)
        {
            if (id >= 0 )
                return await _exhibitRepository.GetByIdAsync(id);

            throw new ArgumentException("Указан неверный Id!");
        }

        public async Task<IEnumerable<Exhibit>> GetByNameAsync(string name)
        {
            return await _exhibitRepository.GetByNameAsync(name);
        }

        public async Task<IEnumerable<Exhibit>> GetByAgeAsync(int age)
        {
            Validator.ValidateAge(age);

            return await _exhibitRepository.GetByAgeAsync(age);
        }

        public async Task<IEnumerable<Exhibit>> GetByDateAsync(string date)
        {
            DateTime currentDate = Validator.ValidateDate(date);

            Debug.WriteLine(currentDate);

            return await _exhibitRepository.GetByDateAsync(currentDate);
        }

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

        public async Task DeleteAsync(int id)
        {
            if (id < 0)
                throw new ArgumentException("Указан неверный Id!");

            await _exhibitRepository.DeleteAsync(id);
        }
    }
}
