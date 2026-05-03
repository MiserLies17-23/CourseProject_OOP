using WinFormsApp_OOP_CourseProject.Controller;

namespace WinFormsApp_OOP_CourseProject
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly ExhibitController _controller;
        private readonly HelloControl _helloControl;

        /// <summary>
        /// Конструктор по умолчанию.
        /// Инициализирует необходимые компоненты формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _controller = new ExhibitController();
            _helloControl = new HelloControl(_controller);
        }

        /// <summary>
        /// Обработчик загрузки формы.
        /// Добавляет основной элемент управления на форму
        /// </summary>
        /// <param name="sender"> Источник события </param>
        /// <param name="e"> Аргументы события </param>
        public void MainForm_Load(object sender, EventArgs e)
        {
            _helloControl.Dock = DockStyle.Fill;
            Controls.Add(_helloControl);
        }
    }
}
