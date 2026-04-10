namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    partial class AddExhibitControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(17, 399);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "Назад";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // AddUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddButton);
            Name = "AddUserControl";
            Size = new Size(750, 450);
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
    }
}
