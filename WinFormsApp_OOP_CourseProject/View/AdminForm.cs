using WinFormsApp_OOP_CourseProject.Controller;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class AdminForm : Form
    {
        private readonly ExhibitController _controller;

        private readonly AdminControl _control;

        private AddExhibitControl _addControl;

        private EditEchibitControl _editControl;

        public AdminForm(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
            _control = new AdminControl(controller);
            _addControl = new AddExhibitControl();
            _editControl = new EditEchibitControl(controller);

            _control.AddUserRequested += OnAddUserRequested;
            _control.ChangeUserRequested += OnEditExhibitRequest;
            _control.CloseFormRequest += OnCloseFormRequest;

            _editControl.BackButtonEvent += () => Controls.Remove(_editControl);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _control.Dock = DockStyle.Fill;
            Controls.Add(_control);
        }

        private void OnAddUserRequested()
        {
            Controls.Remove(_control);

            _addControl.Dock = DockStyle.Fill;
            Controls.Add(_addControl);

            //_addControl.UserAdded += () =>
            //{
            //    Controls.Remove(_addControl);
            //    Controls.Add(_control);
            //};
        }

        private void OnEditExhibitRequest(int id)
        {
            Controls.Remove(_control);
            _editControl.SetExhibit(_controller.GetById(id));

            _editControl.Dock = DockStyle.Fill;
            Controls.Add(_editControl);

            _editControl.BackButtonEvent += () =>
            {
                Controls.Remove(_editControl);

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
