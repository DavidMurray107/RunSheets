using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ReportDataEntryDto
    {
        public int ID { get; set; }
        public int ReportEntryID { get; set; }
        public ReportEntryDto ReportEntry { get; set; }
        public int DataFieldID { get; set; }
        public DataFieldDto DataField { get; set; }
        public decimal Val { get; set; }
        public int Flag { get; set; }
        public string Qualitative { get; set; }
    }
}
