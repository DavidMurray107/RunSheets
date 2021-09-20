using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ReportEntryDto
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastMod { get; set; }
        public DateTime ReportDate { get; set; }
        public int RunsheetID { get; set; }
        public RunsheetDto Runsheet { get; set; }
        public int Col { get; set; }
        public ICollection<ReportDataEntryDto> ReportDataEntries { get; set; }

    }
}
