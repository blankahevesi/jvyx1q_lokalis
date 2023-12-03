using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jvyx1q_lokalis.Models
{
    public partial class budget : UserControl
    {
        Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext context = new Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext();
        public budget()
        {
            InitializeComponent();
            GetFilm();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetFilm();
        }

        private void GetFilm()
        {
            var film = from f in context.Films
                       where f.Names.Contains(textBox1.Text)
                       select f;
            listBox1.DataSource = film.ToList();
            listBox1.DisplayMember = "Names";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film film=(Film)listBox1.SelectedItem;
            var budget = from b in context.Films
                         where b.Id == film.Id
                         select new
                         {
                             budget = b.BudgetX,
                         };
            dataGridView1.DataSource = budget.ToList();
        }
    }
}
