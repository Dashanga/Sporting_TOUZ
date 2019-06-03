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
        public Section Basketball()
        {
            using (Section context = new SportSectionsEntities())
            {
                
                Section sec = context.Sections
                                .Where(b => b.VidSporta == "Баскетбол")
                                .FirstOrDefault();
                return sec;
            }
            
        }
    }
}
