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

        String z;
        public FormVozrast(String zapros)
        {
            InitializeComponent();
            z = zapros;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var form = new FormTrebovaniya(z);
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormEkipirovka(z);
            form.Show();
            this.Hide();
        }
    }
}
