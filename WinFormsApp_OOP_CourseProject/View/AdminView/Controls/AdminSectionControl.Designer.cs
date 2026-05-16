namespace WinFormsApp_OOP_CourseProject.View.Controls
{
    partial class AdminSectionControl
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
            ExhibitSearchFilterPanel = new Panel();
            BackButton = new Button();
            AddButton = new Button();
            ExhibitsLabel = new Label();
            DeleteAllButton = new Button();
            SaveButton = new Button();
            SearchFilterTabControl = new TabControl();
            ((System.ComponentModel.ISupportInitialize)SectionDataGridView).BeginInit();
            ExhibitSearchFilterPanel.SuspendLayout();
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
            EditButtonColumn.Width = 90;
            // 
            // DeleteButtonColumn
            // 
            DeleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DeleteButtonColumn.HeaderText = "Удалить";
            DeleteButtonColumn.MinimumWidth = 6;
            DeleteButtonColumn.Name = "DeleteButtonColumn";
            DeleteButtonColumn.Resizable = DataGridViewTriState.True;
            DeleteButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteButtonColumn.Width = 90;
            // 
            // SectionNameLabel
            // 
            SectionNameLabel.AutoSize = true;
            SectionNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SectionNameLabel.Location = new Point(294, 0);
            SectionNameLabel.Name = "SectionNameLabel";
            SectionNameLabel.Size = new Size(158, 25);
            SectionNameLabel.TabIndex = 1;
            SectionNameLabel.Text = "Название секции";
            // 
            // ExhibitSearchFilterPanel
            // 
            ExhibitSearchFilterPanel.BorderStyle = BorderStyle.FixedSingle;
            ExhibitSearchFilterPanel.Controls.Add(SearchFilterTabControl);
            ExhibitSearchFilterPanel.Location = new Point(3, 28);
            ExhibitSearchFilterPanel.Name = "ExhibitSearchFilterPanel";
            ExhibitSearchFilterPanel.Size = new Size(744, 118);
            ExhibitSearchFilterPanel.TabIndex = 2;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(3, 418);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Выход";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.MenuHighlight;
            AddButton.ForeColor = SystemColors.ButtonFace;
            AddButton.Location = new Point(328, 392);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ExhibitsLabel
            // 
            ExhibitsLabel.AutoSize = true;
            ExhibitsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExhibitsLabel.Location = new Point(308, 161);
            ExhibitsLabel.Name = "ExhibitsLabel";
            ExhibitsLabel.Size = new Size(144, 20);
            ExhibitsLabel.TabIndex = 5;
            ExhibitsLabel.Text = "Список экспонатов";
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.BackColor = Color.Red;
            DeleteAllButton.ForeColor = SystemColors.ButtonFace;
            DeleteAllButton.Location = new Point(588, 392);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(159, 29);
            DeleteAllButton.TabIndex = 6;
            DeleteAllButton.Text = "Очистить таблицу";
            DeleteAllButton.UseVisualStyleBackColor = false;
            DeleteAllButton.Click += DeleteAllButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.LimeGreen;
            SaveButton.ForeColor = SystemColors.ButtonFace;
            SaveButton.Location = new Point(588, 152);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(159, 29);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Сохранить отчёт";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // SearchFilterTabControl
            // 
            SearchFilterTabControl.Location = new Point(-1, -1);
            SearchFilterTabControl.Name = "SearchFilterTabControl";
            SearchFilterTabControl.SelectedIndex = 0;
            SearchFilterTabControl.Size = new Size(744, 118);
            SearchFilterTabControl.TabIndex = 0;
            // 
            // AdminSectionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(DeleteAllButton);
            Controls.Add(ExhibitsLabel);
            Controls.Add(AddButton);
            Controls.Add(BackButton);
            Controls.Add(ExhibitSearchFilterPanel);
            Controls.Add(SectionNameLabel);
            Controls.Add(SectionDataGridView);
            Name = "AdminSectionControl";
            Size = new Size(750, 450);
            Load += MuseumSectionControl_Load;
            ((System.ComponentModel.ISupportInitialize)SectionDataGridView).EndInit();
            ExhibitSearchFilterPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SectionDataGridView;
        private Label SectionNameLabel;
        private Panel ExhibitSearchFilterPanel;
        private Button BackButton;
        private Button AddButton;
        private Label ExhibitsLabel;
        private Button DeleteAllButton;
        private Button SaveButton;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewTextBoxColumn DateOfDiscoveryColumn;
        private DataGridViewTextBoxColumn DiscriptionColumn;
        private DataGridViewButtonColumn EditButtonColumn;
        private DataGridViewButtonColumn DeleteButtonColumn;
        private TabControl SearchFilterTabControl;
    }
}
