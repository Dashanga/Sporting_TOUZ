using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporting
{
    public partial class FormComand : Form
    {
        List<string> vidsporta;
        List<string> rayon;
        List<int> cena;
        List<int> cenaekip;
        List<int> vozrast;
        List<int> trebovaniya;
        public FormComand(List<string> vidsporta, List<string> rayon, List<int> cena, List<int> cenaekip, List<int> vozrast, List<int> trebovaniya)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
            this.cena = cena;
            this.cenaekip = cenaekip;
            this.vozrast = vozrast;
            this.trebovaniya = trebovaniya;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormTrebovaniya(vidsporta, rayon, cena, cenaekip, vozrast);
            form.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            List < string > comand = new List<string>();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    comand.Add(c.Text);
                }
            }
            var form = new FormTravm(vidsporta, rayon, cena, cenaekip, vozrast, trebovaniya, comand);
            form.Show();
            this.Hide();
        }
    }
}
