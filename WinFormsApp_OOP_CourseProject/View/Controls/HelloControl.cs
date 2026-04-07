using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.View.Controls;

namespace WinFormsApp_OOP_CourseProject
{
    public partial class HelloControl : UserControl
    {
        private readonly ExhibitController _controller;

        private AdminControl _adminControl;

        //private VisitorControl _visitorControl;

        public HelloControl(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
            _adminControl = new AdminControl(controller);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm(_controller);
            adminForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
