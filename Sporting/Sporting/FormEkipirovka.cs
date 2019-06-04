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
    public partial class FormEkipirovka : Form
    {
        List<string> vidsporta;
        List<string> rayon;
        List<int> cena;
        public FormEkipirovka(List<string> vidsporta, List<string> rayon, List<int> cena)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
            this.cena = cena;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            List<int> cenaekip = new List<int>();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    String[] str = c.Text.Replace(" рублей", "").Replace(" и более", "").Split('-');
                    foreach (string s in str)
                    {
                        cenaekip.Add(Convert.ToInt32(s.TrimEnd()));
                    }
                }
            }
            var form = new FormVozrast(vidsporta, rayon, cena, cenaekip);
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormCena(vidsporta, rayon);
            form.Show();
            this.Hide();
        }
    }
}
