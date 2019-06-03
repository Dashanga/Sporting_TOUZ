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
        String z;
        public FormEkipirovka(String zapros)
        {
            InitializeComponent();
            z = zapros;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var form = new FormVozrast(z);
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormCena(z);
            form.Show();
            this.Hide();
        }
    }
}
