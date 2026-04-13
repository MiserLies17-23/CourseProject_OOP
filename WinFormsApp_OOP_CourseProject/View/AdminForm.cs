using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    // Организовать перехват исключений
    public partial class AdminForm : Form
    {
        private readonly ExhibitController _controller;

        private readonly AdminControl _control;

        private AddExhibitControl _addControl;

        private EditExhibitControl _editControl;

        public AdminForm(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
            _control = new AdminControl(controller);
            _addControl = new AddExhibitControl(controller);
            _editControl = new EditExhibitControl(controller);

            _control.AddUserRequested += OnAddUserRequested;
            _control.ChangeUserRequested += OnEditExhibitRequest;
            _control.CloseFormRequest += OnCloseFormRequest;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _control.Dock = DockStyle.Fill;
            Controls.Add(_control);
        }

        private void OnAddUserRequested(SectionEnum section)
        {
            Controls.Remove(_control);

            _addControl.SetSection(section);

            _addControl.Dock = DockStyle.Fill;
            Controls.Add(_addControl);

            _addControl.AddButtonEvent += () =>
            {
                Controls.Remove(_addControl);

                _control.InitializeSectionTabs();

                _control.Dock = DockStyle.Fill;
                Controls.Add(_control);
            };

            _addControl.BackButtonEvent += () =>
            {
                Controls.Remove(_addControl);

                _control.Dock = DockStyle.Fill;
                Controls.Add(_control);
            };
        }

        private async Task OnEditExhibitRequest(int id)
        {
            // Все try должны быть здесь!

            Controls.Remove(_control);
            _editControl.SetExhibit(await _controller.GetByIdAsync(id));

            _editControl.Dock = DockStyle.Fill;
            Controls.Add(_editControl);

            _editControl.BackButtonEvent += () =>
            {
                Controls.Remove(_editControl);

                _control.Dock = DockStyle.Fill;
                Controls.Add(_control);
            };

            _editControl.SaveButtonEvent += () =>
            {
                Controls.Remove(_editControl);

                _control.InitializeSectionTabs();

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
