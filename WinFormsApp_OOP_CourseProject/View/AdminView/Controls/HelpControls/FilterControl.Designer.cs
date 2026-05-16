namespace WinFormsApp_OOP_CourseProject.View.AdminView.Controls.HelpControls
{
    partial class FilterControl
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
            TypeLabel = new Label();
            CriteriaLabel = new Label();
            CriteriaComboBox = new ComboBox();
            FilterButton = new Button();
            ExhibitFilterLabel = new Label();
            TypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(617, 39);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 20;
            ClearButton.Text = "Сбросить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TypeLabel.Location = new Point(269, 43);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(34, 20);
            TypeLabel.TabIndex = 19;
            TypeLabel.Text = "Тип";
            // 
            // CriteriaLabel
            // 
            CriteriaLabel.AutoSize = true;
            CriteriaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CriteriaLabel.Location = new Point(15, 43);
            CriteriaLabel.Name = "CriteriaLabel";
            CriteriaLabel.Size = new Size(77, 20);
            CriteriaLabel.TabIndex = 17;
            CriteriaLabel.Text = "Критерий";
            // 
            // CriteriaComboBox
            // 
            CriteriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CriteriaComboBox.FormattingEnabled = true;
            CriteriaComboBox.Items.AddRange(new object[] { "Id", "Название", "Возраст", "Дата обнаружения" });
            CriteriaComboBox.Location = new Point(98, 40);
            CriteriaComboBox.Name = "CriteriaComboBox";
            CriteriaComboBox.Size = new Size(151, 28);
            CriteriaComboBox.TabIndex = 16;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = SystemColors.MenuHighlight;
            FilterButton.ForeColor = SystemColors.ButtonFace;
            FilterButton.Location = new Point(495, 40);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(99, 29);
            FilterButton.TabIndex = 15;
            FilterButton.Text = "Применить";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // ExhibitFilterLabel
            // 
            ExhibitFilterLabel.AutoSize = true;
            ExhibitFilterLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExhibitFilterLabel.Location = new Point(258, 7);
            ExhibitFilterLabel.Name = "ExhibitFilterLabel";
            ExhibitFilterLabel.Size = new Size(202, 23);
            ExhibitFilterLabel.TabIndex = 14;
            ExhibitFilterLabel.Text = "Фильтрация экспонатов";
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            TypeComboBox.Location = new Point(309, 40);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(151, 28);
            TypeComboBox.TabIndex = 21;
            // 
            // FilterControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TypeComboBox);
            Controls.Add(ClearButton);
            Controls.Add(TypeLabel);
            Controls.Add(CriteriaLabel);
            Controls.Add(CriteriaComboBox);
            Controls.Add(FilterButton);
            Controls.Add(ExhibitFilterLabel);
            Name = "FilterControl";
            Size = new Size(740, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Label TypeLabel;
        private Label CriteriaLabel;
        private ComboBox CriteriaComboBox;
        private Button FilterButton;
        private Label ExhibitFilterLabel;
        private ComboBox TypeComboBox;
    }
}
