using WinFormsApp_OOP_CourseProject.Controller;

namespace WinFormsApp_OOP_CourseProject
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class HelloForm : Form
    {
        /// <summary> Таймер для автоматического закрытия формы </summary>
        private readonly System.Windows.Forms.Timer _timer;
        
        /// <summary> Объект HelloControl для отображения содержимого приветственной формы </summary>
        private readonly HelloControl _helloControl;
        
        /// <summary> Флаг для автоматического закрытия формы </summary>
        private bool _isCloseRequested = false;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HelloForm()
        {
            InitializeComponent();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 10000; 
            _timer.Tick += Timer_Tick;

            _helloControl = new HelloControl();
            _helloControl.CloseRequst += OnCloseRequest;
        }

        /// <summary>
        /// Обработчик загрузки формы. 
        /// Выводит содержимое HelloController и запускает таймер
        /// </summary>
        /// <param name="sender"> Объект отправитель (форма) </param>
        /// <param name="e"> Аргументы событий (не используются) </param>
        public void HelloForm_Load(object sender, EventArgs e)
        {
            _helloControl.Dock = DockStyle.Fill;
            Controls.Add(_helloControl);
            _timer.Start(); 
        }

        /// <summary>
        /// Метод для автоматического закрытия формы
        /// </summary>
        /// <param name="sender"> Объект-отправитель </param>
        /// <param name="e"> Аргументы событий (не используются) </param>
        private void Timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            if (!_isCloseRequested)
            {
                Close(); // Закрываем форму через 10 секунд
            }
        }

        /// <summary>
        /// Обрбаотчик закрытия формы для события HelloController
        /// </summary>
        private void OnCloseRequest()
        {
            _isCloseRequested = true;
            _timer.Stop();
            Close();
        }
    }
}
