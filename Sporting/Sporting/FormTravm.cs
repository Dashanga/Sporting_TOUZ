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
    public partial class FormTravm : Form
    {
        List<string> vidsporta;
        List<string> rayon;
        List<int> cena;
        List<int> cenaekip;
        List<int> vozrast;
        List<int> trebovaniya;
        List<string> comand;
        public FormTravm(List<string> vidsporta, List<string> rayon, List<int> cena, List<int> cenaekip, List<int> vozrast, List<int> trebovaniya, List<string> comand)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
            this.cena = cena;
            this.cenaekip = cenaekip;
            this.vozrast = vozrast;
            this.trebovaniya = trebovaniya;
            this.comand = comand;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormComand(vidsporta, rayon, cena, cenaekip, vozrast, trebovaniya);
            form.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            List<int> travm = new List<int>();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    travm.Add(Convert.ToInt32(c.Text));
                }
            }
            var form = new FormChastota(vidsporta, rayon, cena, cenaekip, vozrast, trebovaniya, comand, travm);
            form.Show();
            this.Hide();
        }
    }
}
