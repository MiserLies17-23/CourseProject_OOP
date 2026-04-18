using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class AddExhibitControl : UserControl
    {
        private readonly ExhibitController _controller;

        private SectionEnum _section;

        public event Action? AddButtonEvent;
        
        public event Action? BackButtonEvent;

        public AddExhibitControl(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void SetSection(SectionEnum section)
        {
            _section = section;
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string? name = NameTextBox.Text;

                if (!int.TryParse(AgeTextBox.Text, out int age))
                    throw new ArgumentException("В поле 'Возраст' введено не число!");

                string? date = DateTextBox.Text;
                string? description = DescriptionRichTextBox.Text;

                await _controller.AddAsync(_section, name, age, description, date);

                MessageBox.Show("Экспонат успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddButtonEvent?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка добавления экспоната", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackButtonEvent?.Invoke();
        }
    }
}
