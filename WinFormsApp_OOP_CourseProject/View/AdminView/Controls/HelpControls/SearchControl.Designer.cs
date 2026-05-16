namespace WinFormsApp_OOP_CourseProject.View.AdminView.Controls.HelpControls
{
    partial class SearchControl
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
            ClearButton = new Button();
            ValueLabel = new Label();
            CriteriaValueTextBox = new TextBox();
            CriteriaLabel = new Label();
            CriteriaComboBox = new ComboBox();
            SearchButton = new Button();
            ExhibitSearchLabel = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(613, 42);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 13;
            ClearButton.Text = "Сбросить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ValueLabel.Location = new Point(254, 47);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(77, 20);
            ValueLabel.TabIndex = 12;
            ValueLabel.Text = "Значение";
            // 
            // CriteriaValueTextBox
            // 
            CriteriaValueTextBox.Location = new Point(336, 44);
            CriteriaValueTextBox.Name = "CriteriaValueTextBox";
            CriteriaValueTextBox.Size = new Size(125, 27);
            CriteriaValueTextBox.TabIndex = 11;
            // 
            // CriteriaLabel
            // 
            CriteriaLabel.AutoSize = true;
            CriteriaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CriteriaLabel.Location = new Point(11, 46);
            CriteriaLabel.Name = "CriteriaLabel";
            CriteriaLabel.Size = new Size(77, 20);
            CriteriaLabel.TabIndex = 10;
            CriteriaLabel.Text = "Критерий";
            // 
            // CriteriaComboBox
            // 
            CriteriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CriteriaComboBox.FormattingEnabled = true;
            CriteriaComboBox.Items.AddRange(new object[] { "Id", "Название", "Возраст", "Дата обнаружения" });
            CriteriaComboBox.Location = new Point(94, 43);
            CriteriaComboBox.Name = "CriteriaComboBox";
            CriteriaComboBox.Size = new Size(151, 28);
            CriteriaComboBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.MenuHighlight;
            SearchButton.ForeColor = SystemColors.ButtonFace;
            SearchButton.Location = new Point(496, 43);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 8;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ExhibitSearchLabel
            // 
            ExhibitSearchLabel.AutoSize = true;
            ExhibitSearchLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExhibitSearchLabel.Location = new Point(279, 13);
            ExhibitSearchLabel.Name = "ExhibitSearchLabel";
            ExhibitSearchLabel.Size = new Size(145, 23);
            ExhibitSearchLabel.TabIndex = 7;
            ExhibitSearchLabel.Text = "Поиск экспоната";
            // 
            // SearchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearButton);
            Controls.Add(ValueLabel);
            Controls.Add(CriteriaValueTextBox);
            Controls.Add(CriteriaLabel);
            Controls.Add(CriteriaComboBox);
            Controls.Add(SearchButton);
            Controls.Add(ExhibitSearchLabel);
            Name = "SearchControl";
            Size = new Size(740, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Label ValueLabel;
        private TextBox CriteriaValueTextBox;
        private Label CriteriaLabel;
        private ComboBox CriteriaComboBox;
        private Button SearchButton;
        private Label ExhibitSearchLabel;
    }
}
