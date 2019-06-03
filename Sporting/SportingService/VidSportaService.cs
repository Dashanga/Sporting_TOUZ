using SportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingService
{
    public class VidSportaService
    {
        public String Add (String vid, string sql)
        {
            string zapros = sql + "'" + vid + "'";
            return zapros;
        }
    }
}
