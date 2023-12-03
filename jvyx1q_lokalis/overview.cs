using Microsoft.EntityFrameworkCore;
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
    public partial class overview : UserControl
    {
        Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext context = new Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext();
        public overview()
        {
            InitializeComponent();

            mgenreBindingSource.DataSource = context.Mgenres.ToList();
            filmBindingSource.DataSource=context.Films.ToList();
            genreBindingSource.DataSource=context.Genres.ToList();

            /*mlanguageBindingSource.DataSource = context.Mlanguages.ToList();
            filmBindingSource.DataSource = context.Films.ToList();
            languageBindingSource.DataSource = context.Languages.ToList();*/



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
