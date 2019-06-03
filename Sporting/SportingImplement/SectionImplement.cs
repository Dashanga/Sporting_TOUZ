using SportServiceDAL.Interfaces;
using SportServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingImplement 
{
    public class SectionImplement : ISectionService{
        private DataListSingleton source;
        public SectionImplement()
        {
            source = DataListSingleton.GetInstance();
        }

        public List<SectionViewModel> GetList()
        {
            List<SectionViewModel> result = new List<SectionViewModel>();
            for (int i = 0; i < source.Sections.Count; ++i)
            {
                result.Add(new SectionViewModel
                {
                    Id = source.Sections[i].Id,
                    SectionName = source.Sections[i].SectionName,
                    Area = source.Sections[i].Area,
                    Address = source.Sections[i].Address,
                    Phone = source.Sections[i].Phone,
                    Site = source.Sections[i].Site,
                    FitnessLevel = source.Sections[i].FitnessLevel,
                    InjuryRisk = source.Sections[i].InjuryRisk,
                    PriceLesson = source.Sections[i].PriceLesson,
                    PriceEquipment = source.Sections[i].PriceEquipment,
                    Frequency = source.Sections[i].Frequency
                });
            }
            return result;
        }
        public SectionViewModel GetElement(int id)
        {
            for (int i = 0; i < source.Sections.Count; ++i)
            {
                if (source.Sections[i].Id == id)
                {
                    return new SectionViewModel
                    {
                        Id = source.Sections[i].Id,
                        SectionName = source.Sections[i].SectionName,
                        Area = source.Sections[i].Area,
                        Address = source.Sections[i].Address,
                        Phone = source.Sections[i].Phone,
                        Site = source.Sections[i].Site,
                        FitnessLevel = source.Sections[i].FitnessLevel,
                        InjuryRisk = source.Sections[i].InjuryRisk,
                        PriceLesson = source.Sections[i].PriceLesson,
                        PriceEquipment = source.Sections[i].PriceEquipment,
                        Frequency = source.Sections[i].Frequency
                    };
                }
            }
            throw new Exception("Элемент не найден");
        }
    }
    
}
