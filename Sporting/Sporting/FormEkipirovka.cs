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
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите один пункт", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            List<int> cenaekip = new List<int>();

            String[] str = comboBox1.SelectedItem.ToString().Replace(" рублей", "").Replace(" и более", "").Split('-');
            foreach (string s in str)
            {
                cenaekip.Add(Convert.ToInt32(s.TrimEnd()));
            }

            if (cenaekip.Count == 1)
            {
                cenaekip.Add(int.MaxValue);
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
