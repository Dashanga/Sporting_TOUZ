using SportingService;
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
    public partial class FormVidSporta : Form
    {
        public FormVidSporta()
        {
            InitializeComponent();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            var form = new FormWelcome();
            form.Show();
            this.Hide();

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var form = new FormArea();
            form.Show();
            this.Hide();
        }
        
    }
}
