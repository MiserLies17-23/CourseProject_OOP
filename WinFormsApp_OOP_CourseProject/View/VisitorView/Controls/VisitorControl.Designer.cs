namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    partial class VisitorControl
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
            SectionTabControl = new TabControl();
            SuspendLayout();
            // 
            // SectionTabControl
            // 
            SectionTabControl.Location = new Point(0, 0);
            SectionTabControl.Name = "SectionTabControl";
            SectionTabControl.SelectedIndex = 0;
            SectionTabControl.Size = new Size(815, 490);
            SectionTabControl.TabIndex = 0;
            // 
            // VisitorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SectionTabControl);
            Name = "VisitorControl";
            Size = new Size(820, 500);
            Load += VisitorControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private TabControl SectionTabControl;
    }
}
