using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Repository;

namespace WinFormsApp_OOP_CourseProject.Service
{
    public class ExhibitService
    {
        private readonly ExhibitRepository _exhibitRepository;

        public ExhibitService()
        {
            _exhibitRepository = new ExhibitRepository();
        }

        public void Add(SectionEnum section, string name, int age, string description, DateTime dateOfDiscovery)
        {
            //Валидация

            var newExhibit = new Exhibit(section, name, age, dateOfDiscovery, description);
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

        public Exhibit GetById(int id)
        {
            if (id >= 0 && id < _exhibitRepository.GetCount())
                return _exhibitRepository.GetById(id);

            throw new ArgumentException("Указан неверный Id!");
        }

        public void Edit(int id, SectionEnum newSection, string newName, int newAge, 
            DateTime newDateOfDiscovery, string newDescription)
        {
            if (id < 0 || id >= _exhibitRepository.GetCount())
                throw new ArgumentException("Указан неверный Id!");

            var editExhibit = _exhibitRepository.GetById(id);
            
            // Валидация!

            editExhibit.Section = newSection;
            editExhibit.Name = newName;
            editExhibit.Age = newAge;
            editExhibit.DateOfDiscovery = newDateOfDiscovery;
            editExhibit.Description = newDescription;

            _exhibitRepository.Update(editExhibit);
        }

        public void Delete(int id)
        {
            if (id < 0 || id >= _exhibitRepository.GetCount())
                throw new ArgumentException("Указан неверный Id!");

            _exhibitRepository.Delete(id);
        }
    }
}
