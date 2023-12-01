namespace jvyx1q_lokalis
{
    partial class overview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            crewMemberBindingSource = new BindingSource(components);
            filmBindingSource = new BindingSource(components);
            genreBindingSource = new BindingSource(components);
            languageBindingSource = new BindingSource(components);
            button1 = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateXDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            overviewDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            origTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            budgetXDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            revenueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mgenresDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            mlanguagesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieCrewsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crewMemberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)languageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, namesDataGridViewTextBoxColumn, dateXDataGridViewTextBoxColumn, scoreDataGridViewTextBoxColumn, overviewDataGridViewTextBoxColumn, origTitleDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, budgetXDataGridViewTextBoxColumn, revenueDataGridViewTextBoxColumn, mgenresDataGridViewTextBoxColumn, mlanguagesDataGridViewTextBoxColumn, movieCrewsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = filmBindingSource;
            dataGridView1.Location = new Point(43, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1178, 302);
            dataGridView1.TabIndex = 0;
            // 
            // crewMemberBindingSource
            // 
            crewMemberBindingSource.DataSource = typeof(Models.CrewMember);
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Models.Film);
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(Models.Genre);
            // 
            // languageBindingSource
            // 
            languageBindingSource.DataSource = typeof(Models.Language);
            // 
            // button1
            // 
            button1.Location = new Point(477, 418);
            button1.Name = "button1";
            button1.Size = new Size(367, 29);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            namesDataGridViewTextBoxColumn.HeaderText = "Names";
            namesDataGridViewTextBoxColumn.MinimumWidth = 6;
            namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            namesDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateXDataGridViewTextBoxColumn
            // 
            dateXDataGridViewTextBoxColumn.DataPropertyName = "DateX";
            dateXDataGridViewTextBoxColumn.HeaderText = "DateX";
            dateXDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateXDataGridViewTextBoxColumn.Name = "dateXDataGridViewTextBoxColumn";
            dateXDataGridViewTextBoxColumn.Width = 125;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            scoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // overviewDataGridViewTextBoxColumn
            // 
            overviewDataGridViewTextBoxColumn.DataPropertyName = "Overview";
            overviewDataGridViewTextBoxColumn.HeaderText = "Overview";
            overviewDataGridViewTextBoxColumn.MinimumWidth = 6;
            overviewDataGridViewTextBoxColumn.Name = "overviewDataGridViewTextBoxColumn";
            overviewDataGridViewTextBoxColumn.Width = 125;
            // 
            // origTitleDataGridViewTextBoxColumn
            // 
            origTitleDataGridViewTextBoxColumn.DataPropertyName = "OrigTitle";
            origTitleDataGridViewTextBoxColumn.HeaderText = "OrigTitle";
            origTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            origTitleDataGridViewTextBoxColumn.Name = "origTitleDataGridViewTextBoxColumn";
            origTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // budgetXDataGridViewTextBoxColumn
            // 
            budgetXDataGridViewTextBoxColumn.DataPropertyName = "BudgetX";
            budgetXDataGridViewTextBoxColumn.HeaderText = "BudgetX";
            budgetXDataGridViewTextBoxColumn.MinimumWidth = 6;
            budgetXDataGridViewTextBoxColumn.Name = "budgetXDataGridViewTextBoxColumn";
            budgetXDataGridViewTextBoxColumn.Width = 125;
            // 
            // revenueDataGridViewTextBoxColumn
            // 
            revenueDataGridViewTextBoxColumn.DataPropertyName = "Revenue";
            revenueDataGridViewTextBoxColumn.HeaderText = "Revenue";
            revenueDataGridViewTextBoxColumn.MinimumWidth = 6;
            revenueDataGridViewTextBoxColumn.Name = "revenueDataGridViewTextBoxColumn";
            revenueDataGridViewTextBoxColumn.Width = 125;
            // 
            // mgenresDataGridViewTextBoxColumn
            // 
            mgenresDataGridViewTextBoxColumn.DataPropertyName = "Mgenres";
            mgenresDataGridViewTextBoxColumn.DataSource = genreBindingSource;
            mgenresDataGridViewTextBoxColumn.DisplayMember = "GenreName";
            mgenresDataGridViewTextBoxColumn.HeaderText = "Mgenres";
            mgenresDataGridViewTextBoxColumn.MinimumWidth = 6;
            mgenresDataGridViewTextBoxColumn.Name = "mgenresDataGridViewTextBoxColumn";
            mgenresDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            mgenresDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            mgenresDataGridViewTextBoxColumn.ValueMember = "GenreName";
            mgenresDataGridViewTextBoxColumn.Width = 125;
            // 
            // mlanguagesDataGridViewTextBoxColumn
            // 
            mlanguagesDataGridViewTextBoxColumn.DataPropertyName = "Mlanguages";
            mlanguagesDataGridViewTextBoxColumn.HeaderText = "Mlanguages";
            mlanguagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            mlanguagesDataGridViewTextBoxColumn.Name = "mlanguagesDataGridViewTextBoxColumn";
            mlanguagesDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            mlanguagesDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieCrewsDataGridViewTextBoxColumn
            // 
            movieCrewsDataGridViewTextBoxColumn.DataPropertyName = "MovieCrews";
            movieCrewsDataGridViewTextBoxColumn.HeaderText = "MovieCrews";
            movieCrewsDataGridViewTextBoxColumn.MinimumWidth = 6;
            movieCrewsDataGridViewTextBoxColumn.Name = "movieCrewsDataGridViewTextBoxColumn";
            movieCrewsDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            movieCrewsDataGridViewTextBoxColumn.Width = 125;
            // 
            // overview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "overview";
            Size = new Size(1248, 494);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)crewMemberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)languageBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource filmBindingSource;
        private BindingSource genreBindingSource;
        private BindingSource languageBindingSource;
        private BindingSource crewMemberBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn overviewDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn origTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn budgetXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn mgenresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mlanguagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn movieCrewsDataGridViewTextBoxColumn;
    }
}
