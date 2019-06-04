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
    public partial class FormChastota : Form
    {
        List <string> vidsporta;
        List<string> rayon;
        List<int> cena;
        List<int> cenaekip;
        List<int> vozrast;
        List<int?> trebovaniya;
        List<string> comand;
        List<int?> travm;
        public FormChastota(List<string> vidsporta, List<string> rayon, List<int> cena, List<int> cenaekip, List<int> vozrast, List<int?> trebovaniya, List<string> comand, List<int?> travm)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
            this.cena = cena;
            this.cenaekip = cenaekip;
            this.vozrast = vozrast;
            this.trebovaniya = trebovaniya;
            this.comand = comand;
            this.travm = travm;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormTravm(vidsporta, rayon, cena, cenaekip, vozrast, trebovaniya, comand);
            form.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите один пункт", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            List<int> chastota = new List<int>();

            String[] str = comboBox1.SelectedItem.ToString().Replace(" раза в неделю", "").Split('-');
            foreach (string s in str)
            {
                chastota.Add(Convert.ToInt32(s.TrimEnd()));
            }
            var form = new FormResult(vidsporta, rayon, cena, cenaekip, vozrast, trebovaniya, comand, travm, chastota);
            form.Show();
            this.Hide();
        }
    }
}
