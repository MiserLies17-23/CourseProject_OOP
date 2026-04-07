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
            VisitorButton = new Button();
            AdminButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Header.Location = new Point(269, 20);
            Header.Name = "Header";
            Header.Size = new Size(176, 28);
            Header.TabIndex = 0;
            Header.Text = "Курсовая работа";
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StudentLabel.Location = new Point(269, 66);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(187, 25);
            StudentLabel.TabIndex = 1;
            StudentLabel.Text = "24ВП1, Толстоухов В.";
            // 
            // MuseumLabel
            // 
            MuseumLabel.AutoSize = true;
            MuseumLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MuseumLabel.Location = new Point(328, 163);
            MuseumLabel.Name = "MuseumLabel";
            MuseumLabel.Size = new Size(69, 25);
            MuseumLabel.TabIndex = 2;
            MuseumLabel.Text = "Музей";
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MessageLabel.Location = new Point(89, 197);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(553, 25);
            MessageLabel.TabIndex = 3;
            MessageLabel.Text = "Добро пожаловать в музей! Пожалуйста, выберите форму входа:";
            // 
            // VisitorButton
            // 
            VisitorButton.BackColor = SystemColors.MenuHighlight;
            VisitorButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VisitorButton.ForeColor = SystemColors.ButtonFace;
            VisitorButton.Location = new Point(428, 260);
            VisitorButton.Name = "VisitorButton";
            VisitorButton.Size = new Size(145, 39);
            VisitorButton.TabIndex = 4;
            VisitorButton.Text = "Посетитель";
            VisitorButton.UseVisualStyleBackColor = false;
            // 
            // AdminButton
            // 
            AdminButton.BackColor = SystemColors.HighlightText;
            AdminButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AdminButton.ForeColor = SystemColors.ActiveCaptionText;
            AdminButton.Location = new Point(178, 260);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(145, 39);
            AdminButton.TabIndex = 5;
            AdminButton.Text = "Администратор";
            AdminButton.UseVisualStyleBackColor = false;
            AdminButton.Click += AdminButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitButton.Location = new Point(15, 383);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HelloControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExitButton);
            Controls.Add(AdminButton);
            Controls.Add(VisitorButton);
            Controls.Add(MessageLabel);
            Controls.Add(MuseumLabel);
            Controls.Add(StudentLabel);
            Controls.Add(Header);
            Name = "HelloControl";
            Size = new Size(745, 425);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label StudentLabel;
        private Label MuseumLabel;
        private Label MessageLabel;
        private Button VisitorButton;
        private Button AdminButton;
        private Button ExitButton;
    }
}
