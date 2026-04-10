using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Repository
{
    public interface IExhibitRepository
    {
        IEnumerable<Exhibit> GetAll();

        IEnumerable<Exhibit> GetBySection(SectionEnum section);

        Exhibit? GetById(int id);

        void Add(Exhibit newExhibit);

        void Update(Exhibit editExhibit);

        void Delete(int id);
    }
}
