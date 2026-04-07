using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Utils
{
    public static class MuseumSectionExtension
    {
        public static string GetDisplyName(SectionEnum section)
        {
            return section switch
            {
                SectionEnum.Archaeological => "Архелогия",
                SectionEnum.Ethnographic => "Этнография",
                _ => throw new NotImplementedException()
            };
        }
    }
}
