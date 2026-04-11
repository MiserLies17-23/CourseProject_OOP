using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.DTO;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class EditExhibitControl : UserControl
    {
        private readonly ExhibitController _controller;

        private ExhibitDTO _exhibit;

        public event Action? BackButtonEvent;

        public event Action? SaveButtonEvent;

        public EditExhibitControl(ExhibitController controller) : this(controller, new ExhibitDTO())
        { }

        public EditExhibitControl(ExhibitController controller, ExhibitDTO exhibit)
        {
            InitializeComponent();
            _controller = controller;
            _exhibit = exhibit;
        }

        private void EditEchibitControl_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = _exhibit.Name;
            AgeTextBox.Text = _exhibit.Age.ToString();
            DateTextBox.Text = _exhibit.DateOfDiscovery?.ToString();
            DescriptionRichTextBox.Text = _exhibit.Description;
        }

        public void SetExhibit(ExhibitDTO exhibit)
        {
            _exhibit = exhibit;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string? name = NameTextBox.Text;

                if (!int.TryParse(AgeTextBox.Text, out int age))
                    throw new ArgumentException("В поле 'Возраст' введено не число!");

                string? date = DateTextBox.Text;
                string? description = DescriptionRichTextBox.Text;

                _controller.Edit(_exhibit.Id, _exhibit.Section, name, age, date, description);

                MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveButtonEvent?.Invoke();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка обновления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackButtonEvent?.Invoke();
        }
    }
}
