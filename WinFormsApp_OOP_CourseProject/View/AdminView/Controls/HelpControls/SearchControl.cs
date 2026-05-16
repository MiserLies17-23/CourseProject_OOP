namespace WinFormsApp_OOP_CourseProject.View.AdminView.Controls.HelpControls
{
    public partial class SearchControl : UserControl
    {
        public event Action<int, string>? SearchButtonEvent;

        public event Action? ClearButtonEvent;

        public SearchControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchButtonEvent?.Invoke(CriteriaComboBox.SelectedIndex, CriteriaValueTextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CriteriaComboBox.SelectedItem = null;
            CriteriaValueTextBox.Text = "";

            ClearButtonEvent?.Invoke();
        }
    }
}
