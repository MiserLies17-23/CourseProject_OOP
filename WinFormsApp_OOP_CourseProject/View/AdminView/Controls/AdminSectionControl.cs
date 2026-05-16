using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Utils;
using WinFormsApp_OOP_CourseProject.View.AdminView.Controls.HelpControls;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class AdminSectionControl : UserControl
    {
        private readonly ExhibitController _controller;
        private readonly SectionEnum _section;
        private List<ExhibitDTO> _allExhibits;

        public event Action<SectionEnum>? AddButtonEvent;
        public event Action<int>? ChangeButtonEvent;
        public event Action? CloseButtonEvent;

        public AdminSectionControl(ExhibitController controller, SectionEnum section)
        {
            InitializeComponent();
            _controller = controller;
            _section = section;
            _allExhibits = new List<ExhibitDTO>();
        }

        private async void MuseumSectionControl_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadAllExhibitsAsync();
                LoadSearchFilterControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки формы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSearchFilterControl()
        {
            SearchFilterTabControl.TabPages.Clear();

            var searchControl = new SearchControl();
            searchControl.SearchButtonEvent += async (int criteria, string value) =>
            {
                await Search(criteria, value);
            };
            searchControl.ClearButtonEvent += async () =>
            {
                await LoadAllExhibitsAsync();
            };
            searchControl.Dock = DockStyle.Fill;

            var searchTabPage = new TabPage("Поиск");
            searchTabPage.Controls.Add(searchControl);

            var filterControl = new FilterControl();
            filterControl.Dock = DockStyle.Fill;
            filterControl.FilterButtonEvent += async (int criteria, int type) =>
            {
                await Filter(criteria, type);
            };
            filterControl.ClearButtonEvent += async () =>
            {
                await LoadAllExhibitsAsync();
            };

            var filterTabPage = new TabPage("Фильтрация");
            filterTabPage.Controls.Add(filterControl);

            SearchFilterTabControl.TabPages.Add(searchTabPage);
            SearchFilterTabControl.TabPages.Add(filterTabPage);
        }

        private async Task LoadAllExhibitsAsync()
        {
            _allExhibits = await _controller.GetBySectionAsync(_section);
            LoadExhibitsByList(_allExhibits);
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

        private async Task Search(int criteria, string value)
        {
            try
            {
                switch (criteria)
                {
                    case 0:
                        if (!int.TryParse(value, out int id))
                            throw new ArgumentException("ID должен быть числом!");
                        var exhibit = await _controller.GetByIdAsync(id);
                        var list = exhibit != null ? new List<ExhibitDTO> { exhibit } : new List<ExhibitDTO>();
                        LoadExhibitsByList(list);
                        break;

                    case 1:
                        var exhibitsByName = await _controller.GetByNameAsync(value);
                        LoadExhibitsByList(exhibitsByName);
                        break;

                    case 2:
                        if (!int.TryParse(value, out int age))
                            throw new ArgumentException("Возраст должен быть числом!");
                        var exhibitsByAge = await _controller.GetByAgeAsync(age);
                        LoadExhibitsByList(exhibitsByAge);
                        break;

                    case 3:
                        var exhibitsByDate = await _controller.GetByDateAsync(value);
                        LoadExhibitsByList(exhibitsByDate);
                        break;

                    default:
                        throw new ArgumentException("Неизвестный критерий поиска");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка поиска экспоната", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task Filter(int criteria, int type)
        {
            switch (criteria)
            {
                case 0:
                    if (type == 0)
                        await LoadAllExhibitsAsync();
                    else
                        LoadExhibitsByList([.. _allExhibits.OrderByDescending(e => e.Id)]);
                    break;

                case 1:
                    var sortedByName = type == 0
                        ? [.. _allExhibits.OrderBy(e => e.Name)]
                        : _allExhibits.OrderByDescending(e => e.Name).ToList();
                    LoadExhibitsByList(sortedByName);
                    break;

                case 2:
                    var sortedByAge = type == 0
                        ? [.. _allExhibits.OrderBy(e => e.Age)]
                        : _allExhibits.OrderByDescending(e => e.Age).ToList();
                    LoadExhibitsByList(sortedByAge);
                    break;

                case 3:
                    var sortedByDate = type == 0
                        ? [.. _allExhibits.OrderBy(e => e.DateOfDiscovery)]
                        : _allExhibits.OrderByDescending(e => e.DateOfDiscovery).ToList();
                    LoadExhibitsByList(sortedByDate);
                    break;

                default:
                    throw new ArgumentException("Неизвестный критерий фильтрации");
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить список экспонатов в PDF?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var saveDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"{_section}_exhibits_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.pdf"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                //var exhibits = await _controller.GetBySectionAsync(_section);
                await Task.Run(() => PDFManager.ConvertToPDF(_section, _allExhibits, saveDialog.FileName));
                MessageBox.Show($"PDF отчёт сохранён:\n{Path.GetFileName(saveDialog.FileName)}\n\nЗаписей: {_allExhibits.Count}",
                    "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании PDF:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
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