using WinFormsApp_OOP_CourseProject.Controller;

namespace WinFormsApp_OOP_CourseProject
{
    public partial class MainForm : Form
    {
        private readonly ExhibitController _controller;

        private readonly HelloControl _helloControl;

        public MainForm()
        {
            InitializeComponent();
            _controller = new ExhibitController();
            _helloControl = new HelloControl(_controller);
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            _helloControl.Dock = DockStyle.Fill;
            Controls.Add(_helloControl);
        }
    }
}
