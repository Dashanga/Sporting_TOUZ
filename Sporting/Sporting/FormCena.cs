﻿using System;
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
    public partial class FormCena : Form
    {
        public FormCena()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var form = new FormEkipirovka();
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form = new FormArea();
            form.Show();
            this.Hide();
        }
    }
}
