using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportServiceDAL.BindingModel
{
    public class SectionBindingModel
    {
        public int Id { get; set; }
        public int ViewOfSportId { get; set; }
        public string SectionName { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public int FitnessLevel { get; set; }
        public int InjuryRisk { get; set; }
        public int PriceLesson { get; set; }
        public int PriceEquipment { get; set; }
        public int Frequency { get; set; }
    }
}
