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
        List<string> vidsporta;
        List<string> rayon;
        List<int> cena;
        List<int> cenaekip;
        List<int> vozrast;
        List<int?> trebovaniya;
        List<string> comand;
        List<int?> travm;
        List<int> chastota;
        public FormResult(List<string> vidsporta, List<string> rayon, List<int> cena, List<int> cenaekip, List<int> vozrast, List<int?> trebovaniya, List<string> comand, List<int?> travm, List<int> chastota)
        {
            InitializeComponent();
            this.vidsporta = vidsporta;
            this.rayon = rayon;
            this.cena = cena;
            this.cenaekip = cenaekip;
            this.vozrast = vozrast;
            this.trebovaniya = trebovaniya;
            this.comand = comand;
            this.travm = travm;
            this.chastota = chastota;
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
                int cenaMinLeft = cena[0];
                int cenaMinRight = cena[1];
                int cenaekipMinLeft = cenaekip[0];
                int cenaekipMinRight = cenaekip[1];
                int chastotaMin = chastota[0];
                int chastotaMax = chastota[1];
                int age = vozrast[0];
                var tableObj = context.Table.Where(u => comand.Contains(u.Komand) && vidsporta.Contains(u.VidSporta) && rayon.Contains(u.Rayon) && u.CenaMin >= cenaMinLeft && u.CenaMin <= cenaMinRight && u.CenaEkipMin >= cenaekipMinLeft && u.CenaEkipMin <= cenaekipMinRight && u.AgeMin <= age && u.AgeMax >= age && trebovaniya.Contains(u.Podgotovka) && travm.Contains(u.Travmoopasnost) && u.Chastota >= chastotaMin && u.Chastota <= chastotaMax).ToList();
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
