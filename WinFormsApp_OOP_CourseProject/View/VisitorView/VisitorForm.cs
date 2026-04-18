using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.View.Controls;
using WinFormsApp_OOP_CourseProject.View.VisitorView.Controls;

namespace WinFormsApp_OOP_CourseProject.View
{
    public partial class VisitorForm : Form
    {
        private readonly ExhibitController _controller;

        private readonly VisitorControl _control;

        private ViewExhibitControl _viewControl;

        public VisitorForm(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
            _control = new VisitorControl(_controller);
            _viewControl = new ViewExhibitControl(_controller);

            _control.ViewButtonRequest += OnViewExhibitRequest;
            _control.CloseFormRequest += OnCloseFormRequest;
        }

        private void VisitorForm_Load(object sender, EventArgs e)
        {
            _control.Dock = DockStyle.Fill;
            Controls.Add(_control);
        }

        private async Task OnViewExhibitRequest(int id)
        {
            Controls.Remove(_control);
            _viewControl.SetExhibit(await _controller.GetByIdAsync(id));

            _viewControl.Dock = DockStyle.Fill;
            Controls.Add(_viewControl);

            _viewControl.BackButtonEvent += () =>
            {
                Controls.Remove(_viewControl);

                _control.Dock = DockStyle.Fill;
                Controls.Add(_control);
            };
        }

        private void OnCloseFormRequest()
        {
            foreach (var control in Controls)
            {
                Controls.Remove((Control?)control);
            }
            Close();
        }
    }
}
