using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class SubSectionDto
    {
        public int ID { get; set; }
        public string SubSectionName { get; set; }
        public int SortOrder { get; set; }
        public int RunsheetID { get; set; }
        public RunsheetDto Runsheet { get; set; }
        public IEnumerable<DataFieldDto> DataFields { get; set; }
    }
}
