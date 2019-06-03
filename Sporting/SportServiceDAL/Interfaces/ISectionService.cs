using SportServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportServiceDAL.Interfaces
{
    public interface ISectionService
    {
        List<SectionViewModel> GetList();
        SectionViewModel GetElement(int id);
    }
}
