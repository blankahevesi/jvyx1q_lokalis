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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            genre GenreuserControl = new genre();
            panel1.Controls.Add(GenreuserControl);
            GenreuserControl.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            overview DateUserControl = new overview();
            panel1.Controls.Add(DateUserControl);
            DateUserControl.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            budget BudgetUserControl = new budget();
            panel1.Controls.Add(BudgetUserControl);
            BudgetUserControl.Dock = DockStyle.Fill;

        }
    }
}
