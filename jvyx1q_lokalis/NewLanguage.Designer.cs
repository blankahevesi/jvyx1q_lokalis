namespace jvyx1q_lokalis
{
    partial class NewLanguage
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
            label1 = new Label();
            textBoxID = new TextBox();
            label2 = new Label();
            textBoxLanguage = new TextBox();
            buttonOk = new Button();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 41);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(108, 38);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(217, 27);
            textBoxID.TabIndex = 1;
            textBoxID.Validating += textBoxID_Validating;
            textBoxID.Validated += textBoxID_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 104);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Language:";
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Location = new Point(108, 104);
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new Size(217, 27);
            textBoxLanguage.TabIndex = 6;
            textBoxLanguage.Validating += textBoxLanguage_Validating;
            textBoxLanguage.Validated += textBoxLanguage_Validated;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(649, 272);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(92, 38);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.CausesValidation = false;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(528, 272);
            button1.Name = "button1";
            button1.Size = new Size(92, 38);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // NewLanguage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonOk);
            Controls.Add(textBoxLanguage);
            Controls.Add(label2);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Name = "NewLanguage";
            Text = "NewMovie";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonOk;
        public TextBox textBoxID;
        public TextBox textBoxTitle;
        public TextBox textBoxGenre;
        public TextBox textBoxLanguage;
        public DateTimePicker dateTimePicker1;
        private ErrorProvider errorProvider1;
        private Button button1;
    }
}