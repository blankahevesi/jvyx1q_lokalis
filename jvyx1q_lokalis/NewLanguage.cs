using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jvyx1q_lokalis
{
    public partial class NewLanguage : Form
    {
        public NewLanguage()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                
                    DialogResult = DialogResult.OK;
                
            }
        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{1,3}$");
            if (!regex.IsMatch(textBoxID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxID, "Legalább kettő és legfeljebb 3 számjegyű szám kell!");
            }
            /*else
            {
                int inputId = Convert.ToInt32(textBoxID.Text);

                // Ellenőrizd, hogy az ID egyedi a Form3 DataGridView-jében
                if (!IsIdExistsInDataGridView(inputId))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(textBoxID, "Az ID már létezik a DataGridView-ban!");
                }
            }*/
        }
    


        private void textBoxID_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxID, string.Empty);
        }

        private bool CheckName(string language)
        {
            return !string.IsNullOrEmpty(language);
        }
        private void textBoxLanguage_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBoxLanguage.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxLanguage, "Nem lehet üres!");
            }
        }

        private void textBoxLanguage_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLanguage, string.Empty);
        }

       /* private bool IsIdExistsInDataGridView(int inputId)
        {
            foreach (DataGridViewRow row in ((Form3)Owner).dataGridView1.Rows)
            {
                if (row.Cells["LanguageId"].Value != null && Convert.ToInt32(row.Cells["LanguageId"].Value) == inputId)
                {
                    return true;
                }
            }
            return false;
        }*/
    }
}
