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
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=SportSections;Integrated Security=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(Createzapros(), con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private String Createzapros()
        {
            str = str + ";";
            return str;
        }
    }
}
