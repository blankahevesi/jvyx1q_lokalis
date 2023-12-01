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
    public partial class genre : UserControl
    {
        Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext context = new Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext
        ();

        public genre()
        {
            InitializeComponent();
            GetGenre();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetGenre();
        }

        private void GetGenre()
        {
            var genre = from g in context.Genres
                        where g.GenreName.Contains(textBox1.Text)
                        select g;
            listBox1.DataSource = genre.ToList();
            listBox1.DisplayMember = "GenreName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Genre genre=(Genre)listBox1.SelectedItem;
            var film = from f in context.Mgenres
                       where f.GenreId == genre.GenreId
                       select new
                       {
                           film = f.Movie.Names
                       };
            dataGridView1.DataSource = film.ToList();

        }
    }
}
