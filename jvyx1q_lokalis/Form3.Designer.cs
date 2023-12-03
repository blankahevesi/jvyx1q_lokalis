namespace jvyx1q_lokalis
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            languageIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            mlanguagesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            languageBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)languageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { languageIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, mlanguagesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = languageBindingSource;
            dataGridView1.Location = new Point(43, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(428, 381);
            dataGridView1.TabIndex = 0;
            // 
            // languageIdDataGridViewTextBoxColumn
            // 
            languageIdDataGridViewTextBoxColumn.DataPropertyName = "LanguageId";
            languageIdDataGridViewTextBoxColumn.HeaderText = "LanguageId";
            languageIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            languageIdDataGridViewTextBoxColumn.Name = "languageIdDataGridViewTextBoxColumn";
            languageIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Language1";
            dataGridViewTextBoxColumn1.HeaderText = "Language1";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // mlanguagesDataGridViewTextBoxColumn
            // 
            mlanguagesDataGridViewTextBoxColumn.DataPropertyName = "Mlanguages";
            mlanguagesDataGridViewTextBoxColumn.HeaderText = "Mlanguages";
            mlanguagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            mlanguagesDataGridViewTextBoxColumn.Name = "mlanguagesDataGridViewTextBoxColumn";
            mlanguagesDataGridViewTextBoxColumn.Width = 125;
            // 
            // languageBindingSource
            // 
            languageBindingSource.DataSource = typeof(Models.Language);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(537, 57);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 81);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(537, 144);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 83);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 450);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)languageBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAdd;
        private Button buttonRemove;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn language1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn languageIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn mlanguagesDataGridViewTextBoxColumn;
        private BindingSource languageBindingSource;
        public DataGridView dataGridView1;
    }
}