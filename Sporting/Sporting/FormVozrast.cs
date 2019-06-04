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
    public partial class FormVozrast : Form
    {
        List<string> vidsporta;
        List<string> rayon;
        List<int> cena;
        List<int> cenaekip;
        public FormVozrast(List<string> vidsporta, List<string> rayon, List<int> cena, List<int> cenaekip)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
            this.cena = cena;
            this.cenaekip = cenaekip;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            List<int> vozrast = new List<int>();
            vozrast.Add(Convert.ToInt32(textBoxVozrast.Text));
            var form = new FormTrebovaniya(vidsporta, rayon, cena, cenaekip, vozrast);
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormEkipirovka(vidsporta, rayon, cena);
            form.Show();
            this.Hide();
        }
    }
}
