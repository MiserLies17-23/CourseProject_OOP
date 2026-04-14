using System.Diagnostics;
using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class MuseumSectionControl : UserControl
    {

        private readonly ExhibitController _controller;

        private readonly SectionEnum _section;

        public event Action<SectionEnum>? AddButtonEvent;

        public event Action<int>? ChangeButtonEvent;

        public event Action? CloseButtonEvent;

        public MuseumSectionControl(ExhibitController controller, SectionEnum section)
        {
            InitializeComponent();
            _controller = controller;
            _section = section;
        }

        private async void MuseumSectionControl_Load(object sender, EventArgs e)
        {
            await LoadAllExhibitsAsync();
        }

        private async Task LoadAllExhibitsAsync()
        {
            var exhibits = await _controller.GetBySectionAsync(_section);

            LoadExhibitsByList(exhibits);
        }

        private void LoadExhibitsByList(List<ExhibitDTO> exhibits)
        {
            SectionDataGridView.Rows.Clear();

            string allDates = "";
            foreach (ExhibitDTO exhibit in exhibits)
            {
                Debug.WriteLine($"ID: {exhibit.Id}, Дата из DTO: {exhibit.DateOfDiscovery}");

                int rowIndex = SectionDataGridView.Rows.Add();
                SectionDataGridView.Rows[rowIndex].Cells[0].Value = exhibit.Id;
                SectionDataGridView.Rows[rowIndex].Cells[1].Value = exhibit.Name;
                SectionDataGridView.Rows[rowIndex].Cells[2].Value = exhibit.Age;
                SectionDataGridView.Rows[rowIndex].Cells[3].Value = exhibit.DateOfDiscovery;
                SectionDataGridView.Rows[rowIndex].Cells[4].Value = exhibit.Description;
                SectionDataGridView.Rows[rowIndex].Cells[5].Value = "Изменить";
                SectionDataGridView.Rows[rowIndex].Cells[6].Value = "Удалить";

                allDates += exhibit.DateOfDiscovery + '\n';
            }
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if(CriteriaComboBox.SelectedIndex == 0)
            {
                if (!int.TryParse(CriteriaValueTextBox.Text, out int id))
                    throw new ArgumentException("Id должен быть числом!");

                var exhibits = (List<ExhibitDTO>)[await _controller.GetByIdAsync(id)];

                LoadExhibitsByList(exhibits);
            }
            if (CriteriaComboBox.SelectedIndex == 1)
            {
                var exhibits = await _controller.GetByNameAsync(CriteriaValueTextBox.Text);
                
                LoadExhibitsByList(exhibits);
            }
            if (CriteriaComboBox.SelectedIndex == 2)
            {
                if (!int.TryParse(CriteriaValueTextBox.Text, out int age))
                    throw new ArgumentException("Id должен быть числом!");

                var exhibits = await _controller.GetByAgeAsync(age);

                LoadExhibitsByList(exhibits);

            }
            if (CriteriaComboBox.SelectedIndex == 3)
            {
                var exhibits = await _controller.GetByDateAsync(CriteriaValueTextBox.Text);

                LoadExhibitsByList(exhibits);
            }
        }

        private async void ClearButton_Click(object sender, EventArgs e)
        {
            CriteriaComboBox.SelectedItem = null;
            CriteriaValueTextBox.Text = "";

            await LoadAllExhibitsAsync();
        }

        private async void SectionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        await _controller.DeleteAsync((int)SectionDataGridView.Rows[e.RowIndex].Cells[0].Value);
                        await LoadAllExhibitsAsync();
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
            AddButtonEvent?.Invoke(_section);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CloseButtonEvent?.Invoke();
        }
    }
}
