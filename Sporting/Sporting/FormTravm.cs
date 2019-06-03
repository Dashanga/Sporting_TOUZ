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
    public partial class FormTravm : Form
    {
        String z;
        public FormTravm(String zap)
        {
            InitializeComponent();
            z = zap;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormComand(z);
            form.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var form = new FormResult(z);
            form.Show();
            this.Hide();
        }
    }
}
