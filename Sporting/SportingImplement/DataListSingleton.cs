using SportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingImplement
{
    class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Section> Sections { get; set; }        private DataListSingleton()
        {
            Sections = new List<Section>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
