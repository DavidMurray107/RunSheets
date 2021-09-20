using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class RunsheetDto
    {
        public int ID { get; set; }
        public string SheetName { get; set; }
        public string SheetKey { get; set; }
        public int SortOrder { get; set; }
        public int InputTypeID { get; set; }
        public InputTypeDto InputType { get; set; }
        public IEnumerable<SubSectionDto> SubSections { get; set; }
        public IEnumerable<ReportEntryDto> ReportEntries { get; set; }
    }
}
