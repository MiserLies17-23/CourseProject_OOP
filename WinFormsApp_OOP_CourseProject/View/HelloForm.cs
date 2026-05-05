using WinFormsApp_OOP_CourseProject.Controller;

namespace WinFormsApp_OOP_CourseProject
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class HelloForm : Form
    {
        private readonly System.Windows.Forms.Timer _timer;
        private readonly HelloControl _helloControl;
        private bool _isCloseRequested = false;

        public HelloForm()
        {
            InitializeComponent();

            // Инициализируем таймер
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 10000; 
            _timer.Tick += Timer_Tick;

            _helloControl = new HelloControl();
            _helloControl.CloseRequst += OnCloseRequest;
        }

        public void HelloForm_Load(object sender, EventArgs e)
        {
            _helloControl.Dock = DockStyle.Fill;
            Controls.Add(_helloControl);
            _timer.Start(); // Запускаем таймер
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            if (!_isCloseRequested)
            {
                Close(); // Закрываем форму через 10 секунд
            }
        }

        private void OnCloseRequest()
        {
            _isCloseRequested = true;
            _timer.Stop();
            Close(); // Закрываем по кнопке
        }
    }
}
