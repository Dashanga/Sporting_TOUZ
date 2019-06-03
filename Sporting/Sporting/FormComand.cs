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
    public partial class FormComand : Form
    {
        String z;
        public FormComand(String zap)
        {
            InitializeComponent();
            z = zap;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormTrebovaniya(z);
            form.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var form = new FormTravm(z);
            form.Show();
            this.Hide();
        }
    }
}
