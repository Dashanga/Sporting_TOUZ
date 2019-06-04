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
        public FormChastota(String[] vidsporta, String[] rayon, int[] cena, int[] cenaekip, int[] vozrast, string[] trebovaniya, string[] comand, int[] travm)
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormTravm();
            form.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var form = new FormResult();
            form.Show();
            this.Hide();
        }
    }
}
