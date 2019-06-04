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
            if (string.IsNullOrEmpty(textBoxVozrast.Text))
            {
                MessageBox.Show("Заполните поле", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<int> vozrast = new List<int>();
            try {
                vozrast.Add(Convert.ToInt32(textBoxVozrast.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
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
