namespace WinFormsApp_OOP_CourseProject.View.VisitorView.Controls
{
    partial class ViewExhibitControl
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
            AgeTextBox = new TextBox();
            Agelabel = new Label();
            DateTextBox = new TextBox();
            DateLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            DescriptionLabel = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(17, 453);
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
            HeaderLabel.Location = new Point(262, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(256, 25);
            HeaderLabel.TabIndex = 12;
            HeaderLabel.Text = "Просмотр данных экспоната";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(152, 84);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 13;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(60, 85);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(86, 23);
            NameLabel.TabIndex = 14;
            NameLabel.Text = "Название";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(375, 84);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 15;
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Agelabel.Location = new Point(297, 85);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(72, 23);
            Agelabel.TabIndex = 16;
            Agelabel.Text = "Возраст";
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(649, 84);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.ReadOnly = true;
            DateTextBox.Size = new Size(125, 27);
            DateTextBox.TabIndex = 17;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DateLabel.Location = new Point(518, 86);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(125, 23);
            DateLabel.TabIndex = 18;
            DateLabel.Text = "Дата открытия";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(28, 160);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.ReadOnly = true;
            DescriptionRichTextBox.Size = new Size(746, 273);
            DescriptionRichTextBox.TabIndex = 19;
            DescriptionRichTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(60, 126);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(82, 20);
            DescriptionLabel.TabIndex = 20;
            DescriptionLabel.Text = "Описание:";
            // 
            // ViewExhibitControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "ViewExhibitControl";
            Size = new Size(800, 490);
            Load += ViewExhibitControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label HeaderLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox AgeTextBox;
        private Label Agelabel;
        private TextBox DateTextBox;
        private Label DateLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label DescriptionLabel;
    }
}
