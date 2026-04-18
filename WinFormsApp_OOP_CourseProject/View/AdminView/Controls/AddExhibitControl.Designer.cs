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
            DescriptionLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            DateLabel = new Label();
            DateTextBox = new TextBox();
            Agelabel = new Label();
            AgeTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            BackButton = new Button();
            HeaderLabel = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(322, 413);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 20;
            AddButton.Text = "Сохранить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(51, 124);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(82, 20);
            DescriptionLabel.TabIndex = 19;
            DescriptionLabel.Text = "Описание:";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(19, 158);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(746, 249);
            DescriptionRichTextBox.TabIndex = 18;
            DescriptionRichTextBox.Text = "";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DateLabel.Location = new Point(509, 84);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(125, 23);
            DateLabel.TabIndex = 17;
            DateLabel.Text = "Дата открытия";
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(640, 82);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(125, 27);
            DateTextBox.TabIndex = 16;
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Agelabel.Location = new Point(288, 83);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(72, 23);
            Agelabel.TabIndex = 15;
            Agelabel.Text = "Возраст";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(366, 82);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 14;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(51, 83);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(86, 23);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Название";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(143, 82);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 12;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(19, 443);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 11;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(255, 29);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(273, 25);
            HeaderLabel.TabIndex = 21;
            HeaderLabel.Text = "Добавление нового экспоната";
            // 
            // AddExhibitControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HeaderLabel);
            Controls.Add(AddButton);
            Controls.Add(DescriptionLabel);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(DateLabel);
            Controls.Add(DateTextBox);
            Controls.Add(Agelabel);
            Controls.Add(AgeTextBox);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(BackButton);
            Name = "AddExhibitControl";
            Size = new Size(800, 490);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label DescriptionLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label DateLabel;
        private TextBox DateTextBox;
        private Label Agelabel;
        private TextBox AgeTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button BackButton;
        private Label HeaderLabel;
    }
}
