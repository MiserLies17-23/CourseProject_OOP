using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.View;
using WinFormsApp_OOP_CourseProject.View.Controls;

namespace WinFormsApp_OOP_CourseProject
{
    public partial class HelloControl : UserControl
    {
        private readonly ExhibitController _controller;

        public HelloControl(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm(_controller);
            adminForm.ShowDialog();
        }

        private void VisitorButton_Click(object sender, EventArgs e)
        {
            var visitorForm = new VisitorForm(_controller);
            visitorForm.ShowDialog();
        }
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
