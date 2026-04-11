using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.DTO
{
    public class ExhibitDTO
    {
        public int Id { get; set; }

        public SectionEnum Section { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? DateOfDiscovery { get; set; }

        public string? Description { get; set; }
    }
}
