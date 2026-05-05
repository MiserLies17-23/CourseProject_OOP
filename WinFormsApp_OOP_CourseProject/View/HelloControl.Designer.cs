namespace WinFormsApp_OOP_CourseProject
{
    partial class HelloControl
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
            Header = new Label();
            StudentLabel = new Label();
            MuseumLabel = new Label();
            MessageLabel = new Label();
            ExitButton = new Button();
            OkButton = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Header.Location = new Point(198, 23);
            Header.Name = "Header";
            Header.Size = new Size(176, 28);
            Header.TabIndex = 0;
            Header.Text = "Курсовая работа";
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StudentLabel.Location = new Point(198, 69);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(187, 25);
            StudentLabel.TabIndex = 1;
            StudentLabel.Text = "24ВП1, Толстоухов В.";
            // 
            // MuseumLabel
            // 
            MuseumLabel.AutoSize = true;
            MuseumLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MuseumLabel.Location = new Point(226, 156);
            MuseumLabel.Name = "MuseumLabel";
            MuseumLabel.Size = new Size(117, 25);
            MuseumLabel.TabIndex = 2;
            MuseumLabel.Text = "ИС \"Музей\"";
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MessageLabel.Location = new Point(0, 192);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(607, 25);
            MessageLabel.TabIndex = 3;
            MessageLabel.Text = "Учёт экспонатов; добавление, удаление, изменение и экспорт данных бд";
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitButton.Location = new Point(3, 297);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // OkButton
            // 
            OkButton.BackColor = SystemColors.MenuHighlight;
            OkButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OkButton.ForeColor = SystemColors.ButtonFace;
            OkButton.Location = new Point(242, 239);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(83, 30);
            OkButton.TabIndex = 7;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // HelloControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OkButton);
            Controls.Add(ExitButton);
            Controls.Add(MessageLabel);
            Controls.Add(MuseumLabel);
            Controls.Add(StudentLabel);
            Controls.Add(Header);
            Name = "HelloControl";
            Size = new Size(608, 352);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label StudentLabel;
        private Label MuseumLabel;
        private Label MessageLabel;
        private Button ExitButton;
        private Button OkButton;
    }
}
