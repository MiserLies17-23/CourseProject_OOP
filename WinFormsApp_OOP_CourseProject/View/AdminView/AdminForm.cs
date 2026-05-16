using WinFormsApp_OOP_CourseProject.Controller;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    /// <summary>
    /// Форма администратора для управления экспонатами 
    /// </summary>
    public partial class AdminForm : Form
    {
        private readonly ExhibitController _controller;
        
        private readonly AdminControl _control;
        
        private AddExhibitControl _addControl;
        
        private EditExhibitControl _editControl;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="controller"> Контроллер для работы с экспонатами </param>
        public AdminForm()
        {
            InitializeComponent();

            ShowHelloForm();

            _controller = new ExhibitController();
            _control = new AdminControl(_controller);
            _addControl = new AddExhibitControl(_controller);
            _editControl = new EditExhibitControl(_controller);

            _control.AddUserRequested += OnAddUserRequested;
            _control.ChangeUserRequested += OnEditExhibitRequest;
            _control.CloseFormRequest += OnCloseFormRequest;
        }

        /// <summary>
        /// Обработчик загрузки формы. Добавляет основной элемент управления
        /// </summary>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            _control.Dock = DockStyle.Fill;
            Controls.Add(_control);
        }

        private void ShowHelloForm()
        {
            using var helloForm = new HelloForm();
            helloForm.ShowDialog(); // Блокирует AdminForm до закрытия HelloForm
        }

        /// <summary>
        /// Обрабатывает запрос на добавление нового экспоната.
        /// Переключает отображение с основного элемента на форму добавления
        /// </summary>
        /// <param name="section"> Секция, в которую добавляется экспонат </param>
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

        /// <summary>
        /// Обрабатывает запрос на редактирование существующего экспоната.
        /// Переключает отображение на форму редактирования
        /// </summary>
        /// <param name="id"> id экспоната </param>
        private async Task OnEditExhibitRequest(int id)
        {
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

        /// <summary>
        /// Закрывает форму администратора
        /// </summary>
        private void OnCloseFormRequest()
        {
            foreach (var control in Controls)
            {
                Controls.Remove((Control?)control);
            }
            Application.Exit();
        }
    }
}
