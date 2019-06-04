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
    public partial class FormArea : Form
    {
        List <string> vidsporta;
        public FormArea(List<string> vidsporta)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            List<string> rayon = new List<string>();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    rayon.Add(c.Text);
                }
            }
            var form = new FormCena(vidsporta, rayon);
            form.Show();
            this.Hide();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            var form = new FormVidSporta();
            form.Show();
            this.Hide();
        }
    }
}
