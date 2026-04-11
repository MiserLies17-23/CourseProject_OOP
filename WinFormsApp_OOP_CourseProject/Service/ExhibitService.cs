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

        public void Add(SectionEnum section, string name, int age, string description, string dateOfDiscovery)
        {
            Validator.ValidateExhibit(name, age, description,
               dateOfDiscovery, out DateTime date);

            var newExhibit = new Exhibit(section, name, age, date, description);
            _exhibitRepository.Add(newExhibit);
        }

        public IEnumerable<Exhibit> GetAll()
        {
            return _exhibitRepository.GetAll();
        }

        public IEnumerable<Exhibit> GetBySection(SectionEnum section)
        {
            return _exhibitRepository.GetBySection(section);
        }

        public Exhibit? GetById(int id)
        {
            if (id >= 0 )
                return _exhibitRepository.GetById(id);

            throw new ArgumentException("Указан неверный Id!");
        }

        public void Edit(int id, SectionEnum newSection, string newName, int newAge, 
            string newDateOfDiscovery, string newDescription)
        {
            if (id < 0)
                throw new ArgumentException("Указан неверный Id!");

            var editExhibit = _exhibitRepository.GetById(id);
            
            Validator.ValidateExhibit(newName, newAge, newDescription, 
               newDateOfDiscovery, out DateTime date);

            editExhibit!.Section = newSection;
            editExhibit!.Name = newName;
            editExhibit!.Age = newAge;
            editExhibit!.DateOfDiscovery = date;
            editExhibit!.Description = newDescription;

            _exhibitRepository.Update(editExhibit!);
        }

        public void Delete(int id)
        {
            if (id < 0)
                throw new ArgumentException("Указан неверный Id!");

            _exhibitRepository.Delete(id);
        }
    }
}
