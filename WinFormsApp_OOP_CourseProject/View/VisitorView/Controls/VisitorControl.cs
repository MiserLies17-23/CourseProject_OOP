using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.Model;
using WinFormsApp_OOP_CourseProject.Utils;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    public partial class VisitorControl : UserControl
    {
        private readonly ExhibitController _controller;

        private readonly Dictionary<SectionEnum, VisitorSectionControl> _sections;

        public event Func<int, Task>? ViewButtonRequest;

        public event Action? CloseFormRequest;

        public VisitorControl(ExhibitController controller)
        {
            InitializeComponent();
            _controller = controller;
            _sections = new();
        }

        private void VisitorControl_Load(object sender, EventArgs e)
        {
            InitializeSectionTabs();
        }

        public void InitializeSectionTabs()
        {
            SectionTabControl.TabPages.Clear();

            foreach (SectionEnum section in Enum.GetValues(typeof(SectionEnum)))
            {
                var control = new VisitorSectionControl(_controller, section);
                _sections[section] = control;

                control.CloseButtonEvent += () => CloseFormRequest?.Invoke();
                control.ViewButtonEvent += async (id) =>
                {
                    if (ViewButtonRequest != null)
                        await ViewButtonRequest(id);
                };

                control.Dock = DockStyle.Fill;

                var tabPage = new TabPage(MuseumSectionExtension.GetDisplyName(section));
                tabPage.Controls.Add(control);

                SectionTabControl.TabPages.Add(tabPage);
            }
        }
    }
}
