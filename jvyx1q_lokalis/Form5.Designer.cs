namespace jvyx1q_lokalis
{
    partial class Form5
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
            textBoxFilm = new TextBox();
            textBoxLanguage = new TextBox();
            listBoxFilm = new ListBox();
            listBoxLanguage = new ListBox();
            listBoxAddLanguage = new ListBox();
            buttonRemove = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // textBoxFilm
            // 
            textBoxFilm.Location = new Point(21, 33);
            textBoxFilm.Name = "textBoxFilm";
            textBoxFilm.Size = new Size(144, 27);
            textBoxFilm.TabIndex = 0;
            textBoxFilm.TextChanged += textBoxFilm_TextChanged;
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Location = new Point(468, 43);
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new Size(158, 27);
            textBoxLanguage.TabIndex = 1;
            textBoxLanguage.TextChanged += textBoxLanguage_TextChanged;
            // 
            // listBoxFilm
            // 
            listBoxFilm.FormattingEnabled = true;
            listBoxFilm.ItemHeight = 20;
            listBoxFilm.Location = new Point(21, 98);
            listBoxFilm.Name = "listBoxFilm";
            listBoxFilm.Size = new Size(144, 304);
            listBoxFilm.TabIndex = 2;
            listBoxFilm.SelectedIndexChanged += listBoxFilm_SelectedIndexChanged;
            // 
            // listBoxLanguage
            // 
            listBoxLanguage.FormattingEnabled = true;
            listBoxLanguage.ItemHeight = 20;
            listBoxLanguage.Location = new Point(468, 98);
            listBoxLanguage.Name = "listBoxLanguage";
            listBoxLanguage.Size = new Size(158, 304);
            listBoxLanguage.TabIndex = 3;
            // 
            // listBoxAddLanguage
            // 
            listBoxAddLanguage.FormattingEnabled = true;
            listBoxAddLanguage.ItemHeight = 20;
            listBoxAddLanguage.Location = new Point(191, 98);
            listBoxAddLanguage.Name = "listBoxAddLanguage";
            listBoxAddLanguage.Size = new Size(145, 304);
            listBoxAddLanguage.TabIndex = 4;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(356, 153);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(356, 118);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(listBoxAddLanguage);
            Controls.Add(listBoxLanguage);
            Controls.Add(listBoxFilm);
            Controls.Add(textBoxLanguage);
            Controls.Add(textBoxFilm);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilm;
        private TextBox textBoxLanguage;
        private ListBox listBoxFilm;
        private ListBox listBoxLanguage;
        private ListBox listBoxAddLanguage;
        private Button buttonRemove;
        private Button buttonAdd;
    }
}