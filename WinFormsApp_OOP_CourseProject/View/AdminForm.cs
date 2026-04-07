using WinFormsApp_OOP_CourseProject.Controller;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class AdminForm : Form
    {
        private readonly ExhibitController _controller;

        private readonly AdminControl _control;

        public AdminForm(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
            _control = new AdminControl(controller);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _control.Dock = DockStyle.Fill;
            Controls.Add(_control);
        }
    }
}
