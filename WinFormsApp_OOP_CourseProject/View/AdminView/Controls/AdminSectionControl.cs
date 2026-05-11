using System.Text;
using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class AdminSectionControl : UserControl
    {

        private readonly ExhibitController _controller;

        private readonly SectionEnum _section;

        public event Action<SectionEnum>? AddButtonEvent;

        public event Action<int>? ChangeButtonEvent;

        public event Action? CloseButtonEvent;

        public AdminSectionControl(ExhibitController controller, SectionEnum section)
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

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CriteriaComboBox.SelectedIndex == 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка поиска экспоната", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ClearButton_Click(object sender, EventArgs e)
        {
            CriteriaComboBox.SelectedItem = null;
            CriteriaValueTextBox.Text = "";

            await LoadAllExhibitsAsync();
        }
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить список экспонатов в CSV?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var saveDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = $"{_section}_exhibits_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.csv"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            await SaveExhibitsToCsvAsync(saveDialog.FileName);
        }

        private async Task SaveExhibitsToCsvAsync(string filePath)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var exhibits = await _controller.GetBySectionAsync(_section);

                var csv = new StringBuilder();

                // Заголовки (будут в ячейках A1, B1, C1...)
                csv.AppendLine("\"Id\";\"Название\";\"Возраст\";\"Дата обнаружения\";\"Описание\"");

                // Данные (каждое значение попадёт в свою ячейку)
                foreach (var exhibit in exhibits)
                {
                    csv.Append($"{EscapeCsvValue(exhibit.Id)};");
                    csv.Append($"{EscapeCsvValue(exhibit.Name!)};");
                    csv.Append($"{EscapeCsvValue(exhibit.Age)};");
                    csv.Append($"{EscapeCsvValue(exhibit.DateOfDiscovery!)};");
                    csv.AppendLine(EscapeCsvValue(exhibit.Description!));
                }

                // UTF-8 с BOM для корректной работы Excel с русскими буквами
                await File.WriteAllTextAsync(filePath, csv.ToString(), Encoding.UTF8);

                MessageBox.Show($"Сохранено {exhibits.Count} записей\nФайл: {Path.GetFileName(filePath)}",
                    "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string EscapeCsvValue(object value)
        {
            if (value == null) return "";

            string? str = value.ToString();
            if (string.IsNullOrEmpty(str)) return "";

            if (str.Contains('"') || str.Contains(';') || str.Contains('\n'))
            {
                return $"\"{str.Replace("\"", "\"\"")}\"";
            }

            return str;
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
                        MessageBox.Show("Экспонат успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        private async void DeleteAllButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить все экспонаты данной секции?",
                "Согласие на удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                await _controller.DeleteAllBySectionAsync(_section);
                await LoadAllExhibitsAsync();
                MessageBox.Show("Все экспонаты секции удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CloseButtonEvent?.Invoke();
        }

        
    }
}
