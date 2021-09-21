using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public decimal? Val { get; set; }
        public int Flag { get; set; }
        public string Qualitative { get; set; }
    }
    public class ReportDataEntryForCreationDto 
    {
        [Required(ErrorMessage = "Report Entry is Required")]
        [Range(1,int.MaxValue, ErrorMessage ="Report Entry cannot be 0")]
        public int ReportEntryID { get; set; }
        [Required(ErrorMessage = "Report Entry is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "Report Entry cannot be 0")]
        public int DataFieldID { get; set; }
        //Validation for this OR Qualitative.
        public decimal? Val { get; set; }
        public int Flag { get; set; }
        public string Qualitative { get; set; }
    }
    public class ReportDataEntryForUpdateDto
    {
        [Required(ErrorMessage = "Report Entry is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "Report Entry cannot be 0")]
        public int ReportEntryID { get; set; }
        [Required(ErrorMessage = "Report Entry is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "Report Entry cannot be 0")]
        public int DataFieldID { get; set; }
        //Validation for this OR Qualitative.
        public decimal? Val { get; set; }
        public int Flag { get; set; }
        public string Qualitative { get; set; }
    }

}
