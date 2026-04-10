namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    partial class EditEchibitControl
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
            BackButton = new Button();
            HeaderLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            Agelabel = new Label();
            AgeTextBox = new TextBox();
            DateTextBox = new TextBox();
            DateLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            DescriptionLabel = new Label();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(14, 423);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 0;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(248, 14);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(268, 25);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Изменение данных экспоната";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(138, 89);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(46, 90);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(86, 23);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Название";
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Agelabel.Location = new Point(283, 90);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(72, 23);
            Agelabel.TabIndex = 5;
            Agelabel.Text = "Возраст";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(361, 89);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 4;
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(635, 89);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(125, 27);
            DateTextBox.TabIndex = 6;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DateLabel.Location = new Point(504, 91);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(125, 23);
            DateLabel.TabIndex = 7;
            DateLabel.Text = "Дата открытия";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(14, 165);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(746, 215);
            DescriptionRichTextBox.TabIndex = 8;
            DescriptionRichTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(46, 131);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(82, 20);
            DescriptionLabel.TabIndex = 9;
            DescriptionLabel.Text = "Описание:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(317, 386);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // EditEchibitControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(DescriptionLabel);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(DateLabel);
            Controls.Add(DateTextBox);
            Controls.Add(Agelabel);
            Controls.Add(AgeTextBox);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(HeaderLabel);
            Controls.Add(BackButton);
            Name = "EditEchibitControl";
            Size = new Size(800, 490);
            Load += EditEchibitControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label HeaderLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label Agelabel;
        private TextBox AgeTextBox;
        private TextBox DateTextBox;
        private Label DateLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label DescriptionLabel;
        private Button SaveButton;
    }
}
