using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class MuseumSectionControl : UserControl
    {
        
        private readonly ExhibitController _controller;

        private readonly SectionEnum _section;

        public MuseumSectionControl(ExhibitController controller, SectionEnum section)
        {
            InitializeComponent();
            _controller = controller;
            _section = section;
        }

        private void MuseumSectionControl_Load(object sender, EventArgs e)
        {
            LoadExhibits();
        }

        public void LoadExhibits()
        {
            var exhibits = _controller.GetBySection(SectionEnum.Archaeological);

            foreach (ExhibitDTO exhibit in exhibits)
            {
                int rowIndex = SectionDataGridView.Rows.Add();
                SectionDataGridView.Rows[rowIndex].Cells[0].Value = exhibit.Id;
                SectionDataGridView.Rows[rowIndex].Cells[1].Value = exhibit.Name;
                SectionDataGridView.Rows[rowIndex].Cells[2].Value = exhibit.Age;
                SectionDataGridView.Rows[rowIndex].Cells[3].Value = exhibit.DateOfDiscovery;
                SectionDataGridView.Rows[rowIndex].Cells[4].Value = exhibit.Description;
                SectionDataGridView.Rows[rowIndex].Cells[5].Value = "Посмотреть";
            }
        }
    }
}
