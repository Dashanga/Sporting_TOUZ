using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporting
{
    public partial class FormResult : Form
    {
        String str;
        public FormResult(String zapros)
        {
            InitializeComponent();
            str = zapros;
            //LoadData(zapros);
        }


        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            

            using (var context = new SportSectionsEntities())
            {
                var tableObj = context.Table.SqlQuery(Createzapros()).ToList();
                dataGridView1.DataSource = tableObj; 
            }
        }

        private String Createzapros()
        {
            str = str + ";";
            return str;
        }
    }
}
