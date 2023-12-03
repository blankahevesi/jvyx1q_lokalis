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
using static Azure.Core.HttpHeader;

namespace jvyx1q_lokalis
{
    public partial class Form4 : Form
    {
        Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext context = new Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext();
        public Form4()
        {
            InitializeComponent();
            GetLanguage();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetLanguage();

        }

        private void GetLanguage()
        {
            var language = from l in context.Languages
                           where l.Language1.Contains(textBox1.Text)
                           select l;
            listBoxLanguages.DataSource = language.ToList();
            listBoxLanguages.DisplayMember = "Language1";
        }
        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = (Language)listBoxLanguages.SelectedItem;
            /* var film = from f in context.Mlanguages
                        where f.LanguageId == language.LanguageId
                        select new 
                        {
                            f.Movie.Names
                        };
             listBoxFilms.DisplayMember = "Names";
             listBoxFilms.DataSource = film.ToList();*/
            var film = from f in context.Mlanguages
                       where f.LanguageId == language.LanguageId
                       select f;
            listBoxFilms.DisplayMember = "ID";
            listBoxFilms.DataSource = film.ToList();

        }



        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var languageofthefilms = (Mlanguage)listBoxFilms.SelectedItem;
            var information = from i in context.Films
                              where i.Id == languageofthefilms.Id
                              select new Movies
                              {
                                  Id = i.Id,
                                  Names = i.Names,
                                  Language1 = languageofthefilms.Language.Language1,
                                  Score = i.Score,
                                  Overview = i.Overview
                              };
            dataGridView1.DataSource = information.ToList();

            /* Language language = (Language)listBoxLanguages.SelectedItem;
             var film = from f in context.Mlanguages
                        where f.LanguageId == language.LanguageId
                        select new Movies
                        {
                            Language1 = f.Language.Language1,
                            LanguageId = f.LanguageId,
                            Names = f.Movie.Names
                        };
             dataGridView1.DataSource = film.ToList();*/
        }
    }
}
