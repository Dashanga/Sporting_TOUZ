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
        String z;
        public FormTrebovaniya(String zapros)
        {
            InitializeComponent();
            z = zapros;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var form = new FormComand(z);
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormVozrast(z);
            form.Show();
            this.Hide();
        }
    }
}
