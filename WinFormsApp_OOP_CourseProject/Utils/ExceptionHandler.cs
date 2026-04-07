using System.Runtime.InteropServices;

namespace WinFormsApp_OOP_CourseProject.Utils
{
    /// <summary>
    /// Класс для корректного отображения ошибок 
    /// </summary>
    public class ExceptionHandler
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="hWnd"> Указатель на родиельское окно </param>
        /// <param name="text"> Текст ошибки </param>
        /// <param name="caption"> Заголовок </param>
        /// <param name="type"> Тип кнопок и иконок </param>
        /// <returns> Целочисленный указатель на результат </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern nint MessageBox(
            nint hWnd,
            string text,
            string caption,
            uint type);
    }
}
