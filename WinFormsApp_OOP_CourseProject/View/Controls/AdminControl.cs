using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Utils;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class AdminControl : UserControl
    {
        private readonly ExhibitController _controller;

        private readonly Dictionary<SectionEnum, MuseumSectionControl> _sections;

        public event Action? AddUserRequested;

        public event Action<int>? ChangeUserRequested;

        public event Action? CloseFormRequest;

        public AdminControl(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
            _sections = new();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            InitializeSectionTabs();
        }

        private void InitializeSectionTabs()
        {
            SectionTabControl.TabPages.Clear();

            foreach(SectionEnum section in Enum.GetValues(typeof(SectionEnum)))
            {
                var control = new MuseumSectionControl(_controller, section);
                _sections[section] = control;

                control.AddButtonEvent += () => AddUserRequested?.Invoke();
                control.CloseButtonEvent += () => CloseFormRequest?.Invoke();
                control.ChangeButtonEvent += (id) => ChangeUserRequested?.Invoke(id);

                control.Dock = DockStyle.Fill;

                var tabPage = new TabPage(MuseumSectionExtension.GetDisplyName(section));
                tabPage.Controls.Add(control);

                SectionTabControl.TabPages.Add(tabPage);
            }
        }
    }
}
