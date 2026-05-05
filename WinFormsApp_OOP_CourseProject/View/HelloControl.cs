using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.View;
using WinFormsApp_OOP_CourseProject.View.Controls;

namespace WinFormsApp_OOP_CourseProject
{
    public partial class HelloControl : UserControl
    {

        public event Action? CloseRequst;

        public HelloControl()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CloseRequst?.Invoke();
        }
    }
}
