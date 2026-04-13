namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    partial class MuseumSectionControl
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
            SectionDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            AgeColumn = new DataGridViewTextBoxColumn();
            DateOfDiscoveryColumn = new DataGridViewTextBoxColumn();
            DiscriptionColumn = new DataGridViewTextBoxColumn();
            EditButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn = new DataGridViewButtonColumn();
            SectionNameLabel = new Label();
            ExhibitSearchPanel = new Panel();
            ClearButton = new Button();
            ValueLabel = new Label();
            CriteriaValueTextBox = new TextBox();
            CriteriaLabel = new Label();
            CriteriaComboBox = new ComboBox();
            SearchButton = new Button();
            ExhibitSearchLabel = new Label();
            BackButton = new Button();
            AddButton = new Button();
            ExhibitsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SectionDataGridView).BeginInit();
            ExhibitSearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SectionDataGridView
            // 
            SectionDataGridView.AllowUserToAddRows = false;
            SectionDataGridView.AllowUserToDeleteRows = false;
            SectionDataGridView.AllowUserToResizeColumns = false;
            SectionDataGridView.AllowUserToResizeRows = false;
            SectionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SectionDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, AgeColumn, DateOfDiscoveryColumn, DiscriptionColumn, EditButtonColumn, DeleteButtonColumn });
            SectionDataGridView.Location = new Point(3, 188);
            SectionDataGridView.Name = "SectionDataGridView";
            SectionDataGridView.RowHeadersVisible = false;
            SectionDataGridView.RowHeadersWidth = 51;
            SectionDataGridView.Size = new Size(744, 198);
            SectionDataGridView.TabIndex = 0;
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
            DiscriptionColumn.Width = 170;
            // 
            // EditButtonColumn
            // 
            EditButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            EditButtonColumn.HeaderText = "Изменить";
            EditButtonColumn.MinimumWidth = 6;
            EditButtonColumn.Name = "EditButtonColumn";
            EditButtonColumn.Width = 125;
            // 
            // DeleteButtonColumn
            // 
            DeleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DeleteButtonColumn.HeaderText = "Удалить";
            DeleteButtonColumn.MinimumWidth = 6;
            DeleteButtonColumn.Name = "DeleteButtonColumn";
            DeleteButtonColumn.Resizable = DataGridViewTriState.True;
            DeleteButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteButtonColumn.Width = 125;
            // 
            // SectionNameLabel
            // 
            SectionNameLabel.AutoSize = true;
            SectionNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SectionNameLabel.Location = new Point(269, 16);
            SectionNameLabel.Name = "SectionNameLabel";
            SectionNameLabel.Size = new Size(158, 25);
            SectionNameLabel.TabIndex = 1;
            SectionNameLabel.Text = "Название секции";
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
            ExhibitSearchPanel.Location = new Point(3, 44);
            ExhibitSearchPanel.Name = "ExhibitSearchPanel";
            ExhibitSearchPanel.Size = new Size(744, 102);
            ExhibitSearchPanel.TabIndex = 2;
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
            // BackButton
            // 
            BackButton.Location = new Point(3, 418);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(294, 392);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ExhibitsLabel
            // 
            ExhibitsLabel.AutoSize = true;
            ExhibitsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExhibitsLabel.Location = new Point(269, 157);
            ExhibitsLabel.Name = "ExhibitsLabel";
            ExhibitsLabel.Size = new Size(144, 20);
            ExhibitsLabel.TabIndex = 5;
            ExhibitsLabel.Text = "Список экспонатов";
            // 
            // MuseumSectionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExhibitsLabel);
            Controls.Add(AddButton);
            Controls.Add(BackButton);
            Controls.Add(ExhibitSearchPanel);
            Controls.Add(SectionNameLabel);
            Controls.Add(SectionDataGridView);
            Name = "MuseumSectionControl";
            Size = new Size(750, 450);
            Load += MuseumSectionControl_Load;
            ((System.ComponentModel.ISupportInitialize)SectionDataGridView).EndInit();
            ExhibitSearchPanel.ResumeLayout(false);
            ExhibitSearchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SectionDataGridView;
        private Label SectionNameLabel;
        private Panel ExhibitSearchPanel;
        private Button SearchButton;
        private Label ExhibitSearchLabel;
        private Button BackButton;
        private Button AddButton;
        private Button ClearButton;
        private Label ValueLabel;
        private TextBox CriteriaValueTextBox;
        private Label CriteriaLabel;
        private ComboBox CriteriaComboBox;
        private Label ExhibitsLabel;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewTextBoxColumn DateOfDiscoveryColumn;
        private DataGridViewTextBoxColumn DiscriptionColumn;
        private DataGridViewButtonColumn EditButtonColumn;
        private DataGridViewButtonColumn DeleteButtonColumn;
    }
}
