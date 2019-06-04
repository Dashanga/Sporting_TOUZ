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
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите один пункт", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            List<int> cena = new List<int>();
           
            String[] str = comboBox1.SelectedItem.ToString().Replace(" рублей", "").Replace(" и более", "").Split('-');
            foreach (string s in str)
            {
                cena.Add(Convert.ToInt32(s.TrimEnd()));
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
