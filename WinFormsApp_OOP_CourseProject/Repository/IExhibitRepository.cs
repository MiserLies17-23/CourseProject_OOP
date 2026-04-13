using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Repository
{
    public interface IExhibitRepository
    {
        Task<IEnumerable<Exhibit>> GetAllAsync();

        Task<IEnumerable<Exhibit>> GetBySectionAsync(SectionEnum section);

        Task<Exhibit?> GetByIdAsync(int id);

        Task<IEnumerable<Exhibit>> GetByNameAsync(string name);

        Task<IEnumerable<Exhibit>> GetByDateAsync(DateTime date);

        Task<IEnumerable<Exhibit>> GetByAgeAsync(int age);

        Task AddAsync(Exhibit newExhibit);

        Task UpdateAsync(Exhibit editExhibit);

        Task DeleteAsync(int id);
    }
}
