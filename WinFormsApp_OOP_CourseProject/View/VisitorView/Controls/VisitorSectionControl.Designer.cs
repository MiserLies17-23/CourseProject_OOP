namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    partial class VisitorSectionControl
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
            ExhibitsLabel = new Label();
            BackButton = new Button();
            ExhibitSearchPanel = new Panel();
            ClearButton = new Button();
            ValueLabel = new Label();
            CriteriaValueTextBox = new TextBox();
            CriteriaLabel = new Label();
            CriteriaComboBox = new ComboBox();
            SearchButton = new Button();
            ExhibitSearchLabel = new Label();
            SectionNameLabel = new Label();
            SectionDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            AgeColumn = new DataGridViewTextBoxColumn();
            DateOfDiscoveryColumn = new DataGridViewTextBoxColumn();
            DiscriptionColumn = new DataGridViewTextBoxColumn();
            EditButtonColumn = new DataGridViewButtonColumn();
            ExhibitSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SectionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ExhibitsLabel
            // 
            ExhibitsLabel.AutoSize = true;
            ExhibitsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExhibitsLabel.Location = new Point(269, 151);
            ExhibitsLabel.Name = "ExhibitsLabel";
            ExhibitsLabel.Size = new Size(144, 20);
            ExhibitsLabel.TabIndex = 11;
            ExhibitsLabel.Text = "Список экспонатов";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(3, 412);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 9;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ExhibitSearchPanel
            // 
            ExhibitSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            ExhibitSearchPanel.Controls.Add(ClearButton);
            ExhibitSearchPanel.Controls.Add(ValueLabel);
            ExhibitSearchPanel.Controls.Add(CriteriaValueTextBox);
            ExhibitSearchPanel.Controls.Add(CriteriaLabel);
            ExhibitSearchPanel.Controls.Add(CriteriaComboBox);
            ExhibitSearchPanel.Controls.Add(SearchButton);
            ExhibitSearchPanel.Controls.Add(ExhibitSearchLabel);
            ExhibitSearchPanel.Location = new Point(3, 38);
            ExhibitSearchPanel.Name = "ExhibitSearchPanel";
            ExhibitSearchPanel.Size = new Size(744, 102);
            ExhibitSearchPanel.TabIndex = 8;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(605, 40);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Сбросить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ValueLabel.Location = new Point(246, 45);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(77, 20);
            ValueLabel.TabIndex = 5;
            ValueLabel.Text = "Значение";
            // 
            // CriteriaValueTextBox
            // 
            CriteriaValueTextBox.Location = new Point(328, 42);
            CriteriaValueTextBox.Name = "CriteriaValueTextBox";
            CriteriaValueTextBox.Size = new Size(125, 27);
            CriteriaValueTextBox.TabIndex = 4;
            // 
            // CriteriaLabel
            // 
            CriteriaLabel.AutoSize = true;
            CriteriaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CriteriaLabel.Location = new Point(3, 44);
            CriteriaLabel.Name = "CriteriaLabel";
            CriteriaLabel.Size = new Size(77, 20);
            CriteriaLabel.TabIndex = 3;
            CriteriaLabel.Text = "Критерий";
            // 
            // CriteriaComboBox
            // 
            CriteriaComboBox.FormattingEnabled = true;
            CriteriaComboBox.Items.AddRange(new object[] { "Id", "Название", "Возраст", "Дата обнаружения" });
            CriteriaComboBox.Location = new Point(86, 41);
            CriteriaComboBox.Name = "CriteriaComboBox";
            CriteriaComboBox.Size = new Size(151, 28);
            CriteriaComboBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(488, 41);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ExhibitSearchLabel
            // 
            ExhibitSearchLabel.AutoSize = true;
            ExhibitSearchLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExhibitSearchLabel.Location = new Point(271, 11);
            ExhibitSearchLabel.Name = "ExhibitSearchLabel";
            ExhibitSearchLabel.Size = new Size(145, 23);
            ExhibitSearchLabel.TabIndex = 0;
            ExhibitSearchLabel.Text = "Поиск экспоната";
            // 
            // SectionNameLabel
            // 
            SectionNameLabel.AutoSize = true;
            SectionNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SectionNameLabel.Location = new Point(269, 10);
            SectionNameLabel.Name = "SectionNameLabel";
            SectionNameLabel.Size = new Size(158, 25);
            SectionNameLabel.TabIndex = 7;
            SectionNameLabel.Text = "Название секции";
            // 
            // SectionDataGridView
            // 
            SectionDataGridView.AllowUserToAddRows = false;
            SectionDataGridView.AllowUserToDeleteRows = false;
            SectionDataGridView.AllowUserToResizeColumns = false;
            SectionDataGridView.AllowUserToResizeRows = false;
            SectionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SectionDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, AgeColumn, DateOfDiscoveryColumn, DiscriptionColumn, EditButtonColumn });
            SectionDataGridView.Location = new Point(3, 182);
            SectionDataGridView.Name = "SectionDataGridView";
            SectionDataGridView.RowHeadersVisible = false;
            SectionDataGridView.RowHeadersWidth = 51;
            SectionDataGridView.Size = new Size(744, 224);
            SectionDataGridView.TabIndex = 6;
            SectionDataGridView.CellContentClick += SectionDataGridView_CellContentClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 60;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Название";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 125;
            // 
            // AgeColumn
            // 
            AgeColumn.HeaderText = "Возраст";
            AgeColumn.MinimumWidth = 6;
            AgeColumn.Name = "AgeColumn";
            AgeColumn.Width = 75;
            // 
            // DateOfDiscoveryColumn
            // 
            DateOfDiscoveryColumn.HeaderText = "Дата обнаружения";
            DateOfDiscoveryColumn.MinimumWidth = 6;
            DateOfDiscoveryColumn.Name = "DateOfDiscoveryColumn";
            DateOfDiscoveryColumn.Width = 110;
            // 
            // DiscriptionColumn
            // 
            DiscriptionColumn.HeaderText = "Описание";
            DiscriptionColumn.MinimumWidth = 6;
            DiscriptionColumn.Name = "DiscriptionColumn";
            DiscriptionColumn.Width = 220;
            // 
            // EditButtonColumn
            // 
            EditButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            EditButtonColumn.HeaderText = "Посмотреть";
            EditButtonColumn.MinimumWidth = 6;
            EditButtonColumn.Name = "EditButtonColumn";
            EditButtonColumn.Width = 125;
            // 
            // VisitorSectionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExhibitsLabel);
            Controls.Add(BackButton);
            Controls.Add(ExhibitSearchPanel);
            Controls.Add(SectionNameLabel);
            Controls.Add(SectionDataGridView);
            Name = "VisitorSectionControl";
            Size = new Size(750, 450);
            Load += VisitorSectionControl_Load;
            ExhibitSearchPanel.ResumeLayout(false);
            ExhibitSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SectionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExhibitsLabel;
        private Button BackButton;
        private Panel ExhibitSearchPanel;
        private Button ClearButton;
        private Label ValueLabel;
        private TextBox CriteriaValueTextBox;
        private Label CriteriaLabel;
        private ComboBox CriteriaComboBox;
        private Button SearchButton;
        private Label ExhibitSearchLabel;
        private Label SectionNameLabel;
        private DataGridView SectionDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewTextBoxColumn DateOfDiscoveryColumn;
        private DataGridViewTextBoxColumn DiscriptionColumn;
        private DataGridViewButtonColumn EditButtonColumn;
    }
}
