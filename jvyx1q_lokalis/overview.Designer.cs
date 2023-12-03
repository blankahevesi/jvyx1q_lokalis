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
            button1 = new Button();
            mgenreBindingSource = new BindingSource(components);
            filmBindingSource = new BindingSource(components);
            genreBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            genreIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mgenreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, movieIdDataGridViewTextBoxColumn, genreIdDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, movieDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mgenreBindingSource;
            dataGridView1.Location = new Point(31, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1053, 332);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(31, 411);
            button1.Name = "button1";
            button1.Size = new Size(1053, 46);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mgenreBindingSource
            // 
            mgenreBindingSource.DataSource = typeof(Models.Mgenre);
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Models.Film);
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(Models.Genre);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieIdDataGridViewTextBoxColumn
            // 
            movieIdDataGridViewTextBoxColumn.DataPropertyName = "MovieId";
            movieIdDataGridViewTextBoxColumn.DataSource = filmBindingSource;
            movieIdDataGridViewTextBoxColumn.DisplayMember = "Names";
            movieIdDataGridViewTextBoxColumn.HeaderText = "MovieId";
            movieIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
            movieIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            movieIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            movieIdDataGridViewTextBoxColumn.ValueMember = "Id";
            movieIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            genreIdDataGridViewTextBoxColumn.DataSource = genreBindingSource;
            genreIdDataGridViewTextBoxColumn.DisplayMember = "GenreName";
            genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            genreIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            genreIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            genreIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            genreIdDataGridViewTextBoxColumn.ValueMember = "GenreId";
            genreIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieDataGridViewTextBoxColumn
            // 
            movieDataGridViewTextBoxColumn.DataPropertyName = "Movie";
            movieDataGridViewTextBoxColumn.HeaderText = "Movie";
            movieDataGridViewTextBoxColumn.MinimumWidth = 6;
            movieDataGridViewTextBoxColumn.Name = "movieDataGridViewTextBoxColumn";
            movieDataGridViewTextBoxColumn.Width = 125;
            // 
            // overview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "overview";
            Size = new Size(1116, 484);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mgenreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn movieIdDataGridViewTextBoxColumn;
        private BindingSource filmBindingSource;
        private DataGridViewComboBoxColumn genreIdDataGridViewTextBoxColumn;
        private BindingSource genreBindingSource;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn;
        private BindingSource mgenreBindingSource;
    }
}
