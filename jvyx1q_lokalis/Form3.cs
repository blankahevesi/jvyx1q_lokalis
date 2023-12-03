using jvyx1q_lokalis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jvyx1q_lokalis
{
    public partial class Form3 : Form
    {
        Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext context = new Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext();

        public Form3()
        {
            InitializeComponent();
            languageBindingSource.DataSource = context.Languages.ToList();


        }
        /* public bool IsIdExistsInDataGridView(int inputId)
         {
             foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 if (row.Cells["LanguageId"].Value != null && Convert.ToInt32(row.Cells["LanguageId"].Value) == inputId)
                 {
                     return true;
                 }
             }
             return false;
         }*/
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewLanguage newLanguage = new NewLanguage();
            if (newLanguage.ShowDialog() == DialogResult.OK)
            {
                Models.Language language = new Models.Language();
                language.LanguageId = Convert.ToInt16(newLanguage.textBoxID.Text);
                language.Language1 = newLanguage.textBoxLanguage.Text;
                context.Languages.Add(language);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.InnerException.Message);
                }

                languageBindingSource.DataSource = context.Languages.ToList();

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
