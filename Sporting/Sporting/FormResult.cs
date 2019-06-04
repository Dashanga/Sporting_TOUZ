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
        public FormResult(String[] vidsporta, String[] rayon, int[] cena, int[] cenaekip, int[] vozrast, string[] trebovaniya, string[] comand, int[] travm, int[] chastota)
        {
            InitializeComponent();
        }


        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Вашему ребёнку подойдут секции:");
            using (var context = new SportSectionsEntities())
            {
                var tableObj = context.Table.Where(u => u.Komand == "Командный").ToList();
                int i = 1;
                foreach (var obj in tableObj)
                {
                    string[] result = new string[] { i.ToString(), "Название секции:", obj.NameOfSection, "Вид спорта:", obj.VidSporta, "Адрес:", obj.Place, "Контакты:", obj.Contact, ""};
                    listBox1.Items.AddRange(result);
                    i++;
                }
            }


            
        }
    }
}
