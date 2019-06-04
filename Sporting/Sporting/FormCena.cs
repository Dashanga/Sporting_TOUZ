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
    public partial class FormCena : Form
    {
        List <string> vidsporta;
        List<string> rayon;
        public FormCena(List<string> vidsporta, List<string> rayon)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            List<int> cena = new List<int>();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    String[] str = c.Text.Replace(" рублей", "").Replace(" и более", "").Split('-');
                    foreach (string s in str)
                    {
                        cena.Add(Convert.ToInt32(s.TrimEnd()));
                    }
                }
            }
            if (cena.Count == 1)
            {
                cena.Add(int.MaxValue);
            }
            var form = new FormEkipirovka(vidsporta, rayon, cena);
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormArea(vidsporta);
            form.Show();
            this.Hide();
        }
    }
}
