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
            ViewButtonColumn = new DataGridViewButtonColumn();
            SectionNameLabel = new Label();
            ExhibitSearchPanel = new Panel();
            SearchButton = new Button();
            ExhibitSearchLabel = new Label();
            BackButton = new Button();
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
            SectionDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, AgeColumn, DateOfDiscoveryColumn, DiscriptionColumn, ViewButtonColumn });
            SectionDataGridView.Location = new Point(3, 210);
            SectionDataGridView.Name = "SectionDataGridView";
            SectionDataGridView.RowHeadersVisible = false;
            SectionDataGridView.RowHeadersWidth = 51;
            SectionDataGridView.Size = new Size(744, 176);
            SectionDataGridView.TabIndex = 0;
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
            DateOfDiscoveryColumn.Width = 170;
            // 
            // DiscriptionColumn
            // 
            DiscriptionColumn.HeaderText = "Описание";
            DiscriptionColumn.MinimumWidth = 6;
            DiscriptionColumn.Name = "DiscriptionColumn";
            DiscriptionColumn.Width = 170;
            // 
            // ViewButtonColumn
            // 
            ViewButtonColumn.HeaderText = "Посмотреть";
            ViewButtonColumn.MinimumWidth = 6;
            ViewButtonColumn.Name = "ViewButtonColumn";
            ViewButtonColumn.Width = 125;
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
            ExhibitSearchPanel.Controls.Add(SearchButton);
            ExhibitSearchPanel.Controls.Add(ExhibitSearchLabel);
            ExhibitSearchPanel.Location = new Point(3, 44);
            ExhibitSearchPanel.Name = "ExhibitSearchPanel";
            ExhibitSearchPanel.Size = new Size(744, 143);
            ExhibitSearchPanel.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(645, 109);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = true;
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
            // 
            // MuseumSectionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewTextBoxColumn DateOfDiscoveryColumn;
        private DataGridViewTextBoxColumn DiscriptionColumn;
        private DataGridViewButtonColumn ViewButtonColumn;
        private Label SectionNameLabel;
        private Panel ExhibitSearchPanel;
        private Button SearchButton;
        private Label ExhibitSearchLabel;
        private Button BackButton;
    }
}
