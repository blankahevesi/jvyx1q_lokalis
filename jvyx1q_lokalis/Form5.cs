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
    public partial class Form5 : Form
    {
        Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext context = new Models.CUsersAcerDesktopBeadandóenJvyx1qLokalisJvyx1qLokalisDatabase1MdfContext();
        public Form5()
        {
            InitializeComponent();
            GetFilms();
            GetLanguage();
        }

        private void textBoxFilm_TextChanged(object sender, EventArgs e)
        {
            GetFilms();

        }

        private void GetFilms()
        {
            var film = from f in context.Films
                       where f.Names.Contains(textBoxFilm.Text)
                       select f;
            listBoxFilm.DataSource = film.ToList();
            listBoxFilm.DisplayMember = "Names";
        }

        private void textBoxLanguage_TextChanged(object sender, EventArgs e)
        {
            GetLanguage();
        }

        private void GetLanguage()
        {
            var language = from l in context.Languages
                           where l.Language1.Contains(textBoxLanguage.Text)
                           select l;
            listBoxLanguage.DataSource = language.ToList();
            listBoxLanguage.DisplayMember = "Language1";
        }

        private void listBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Languageofthefilm();

        }

        private void Languageofthefilm()
        {
            var selectedFilm = (Film)listBoxFilm.SelectedItem;
            var languageofthefilm = from f in context.Mlanguages
                                    where f.Id == selectedFilm.Id
                                    select new Languagesofthefilm
                                    {
                                        Language1 = f.Language.Language1,
                                        LanguageId = f.Id,


                                    };
            listBoxAddLanguage.DataSource = languageofthefilm.ToList();
            listBoxAddLanguage.DisplayMember = "Language1";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedfilm = (Film)listBoxLanguage.SelectedItem;
            var selectedLanguage = (Language)listBoxLanguage.SelectedItem;

            Language newlanguage = new Language();
            newlanguage.LanguageId = selectedLanguage.LanguageId;
            newlanguage.Language1 = selectedLanguage.Language1;
            context.Languages.Add(newlanguage);
            try
            {
                context.SaveChanges();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            Languageofthefilm();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var selectedlanguage=(Languagesofthefilm)listBoxAddLanguage.SelectedItem;
            var languagetobedeleted = (from l in context.Languages
                                       where l.LanguageId == selectedlanguage.LanguageId
                                       select l).FirstOrDefault();
            context.Languages.Remove(languagetobedeleted);
            try
            {
                context.SaveChanges();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            Languageofthefilm();
        }
    }
}//kiválasztott filmhez tartozó nyelvek

