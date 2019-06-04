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
    public partial class FormTrebovaniya : Form
    {
        List<string> vidsporta;
        List<string> rayon;
        List<int> cena;
        List<int> cenaekip;
        List<int> vozrast;
        public FormTrebovaniya(List<string> vidsporta, List<string> rayon, List<int> cena, List<int> cenaekip, List<int> vozrast)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
            this.cena = cena;
            this.cenaekip = cenaekip;
            this.vozrast = vozrast;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("Выберите хотя бы один пункт", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            List<int?> trebovaniya = new List<int?>();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    trebovaniya.Add(Convert.ToInt32(c.Text));
                }
            }
            var form = new FormComand(vidsporta, rayon, cena, cenaekip, vozrast, trebovaniya);
            form.Show();
            this.Hide();
        }
        Boolean Check()
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormVozrast(vidsporta, rayon, cena, cenaekip);
            form.Show();
            this.Hide();
        }
    }
}
