namespace WinFormsApp_OOP_CourseProject.View.AdminView.Controls.HelpControls
{
    public partial class FilterControl : UserControl
    {
        public event Action<int, int>? FilterButtonEvent;

        public event Action? ClearButtonEvent;

        public FilterControl()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterButtonEvent?.Invoke(CriteriaComboBox.SelectedIndex, TypeComboBox.SelectedIndex);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CriteriaComboBox.SelectedItem = null;
            TypeComboBox.SelectedItem = null;

            ClearButtonEvent?.Invoke();
        }

    }
}
