using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class MuseumSectionControl : UserControl
    {

        private readonly ExhibitController _controller;

        private readonly SectionEnum _section;

        public event Action? AddButtonEvent;

        public event Action<int>? ChangeButtonEvent;

        public event Action? CloseButtonEvent;

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
            SectionDataGridView.Rows.Clear();

            var exhibits = _controller.GetBySection(_section);

            foreach (ExhibitDTO exhibit in exhibits)
            {
                int rowIndex = SectionDataGridView.Rows.Add();
                SectionDataGridView.Rows[rowIndex].Cells[0].Value = exhibit.Id;
                SectionDataGridView.Rows[rowIndex].Cells[1].Value = exhibit.Name;
                SectionDataGridView.Rows[rowIndex].Cells[2].Value = exhibit.Age;
                SectionDataGridView.Rows[rowIndex].Cells[3].Value = exhibit.DateOfDiscovery;
                SectionDataGridView.Rows[rowIndex].Cells[4].Value = exhibit.Description;
                SectionDataGridView.Rows[rowIndex].Cells[5].Value = "Изменить";
                SectionDataGridView.Rows[rowIndex].Cells[6].Value = "Удалить";
            }
        }

        private void SectionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6)
                {
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить экспонат?",
                        "Согласие на удаление",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        _controller.Delete((int)SectionDataGridView.Rows[e.RowIndex].Cells[0].Value);
                        LoadExhibits();
                    }
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    int id = (int)SectionDataGridView.Rows[e.RowIndex].Cells[0].Value;
                    ChangeButtonEvent?.Invoke(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddButtonEvent?.Invoke();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CloseButtonEvent?.Invoke();
        }
    }
}
