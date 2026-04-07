namespace WinFormsApp_OOP_CourseProject.Model
{
    public class Exhibit
    {
        public int Id { get; set; }

        public SectionEnum Section { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public DateTime DateOfDiscovery { get; set; }

        public string? Description { get; set; }

        public Exhibit()
        {
            Section = SectionEnum.Archaeological;
            Name = "Неизвестно";
            Age = 0;
            DateOfDiscovery = DateTime.Now;
            Description = "...";
        }

        public Exhibit(SectionEnum section, string name, int age, DateTime dateOfDiscovery, string description)
        {
            Section = section;
            Name = name;
            Age = age;
            DateOfDiscovery = dateOfDiscovery;
            Description = description;
        }
    }
}
