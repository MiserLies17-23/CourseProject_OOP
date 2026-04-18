using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.DTO;

namespace WinFormsApp_OOP_CourseProject.View.VisitorView.Controls
{
    public partial class ViewExhibitControl : UserControl
    {
        private readonly ExhibitController _controller;

        private ExhibitDTO _exhibit;

        public event Action? BackButtonEvent;

        public ViewExhibitControl(ExhibitController controller) : this(controller, new ExhibitDTO())
        {}

        public ViewExhibitControl(ExhibitController controller, ExhibitDTO exhibit)
        {
            InitializeComponent();
            _controller = controller;
            _exhibit = exhibit;
        }

        private void ViewExhibitControl_Load(object sender, EventArgs e)
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackButtonEvent?.Invoke();
        }
    }
}
