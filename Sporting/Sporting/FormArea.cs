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
        String z;
        public FormArea(String zapros)
        {
            InitializeComponent();
            z = zapros;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var form = new FormCena(z);
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
