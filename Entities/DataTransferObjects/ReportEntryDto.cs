using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public class ReportEntryForCreationDto
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastMod { get; set; }
        [Required(ErrorMessage = "Report Date is Required.")]
        public DateTime ReportDate { get; set; }
        [Required(ErrorMessage = "A Runsheet Is Required")]
        [Range(1, int.MaxValue,ErrorMessage ="The Runsheet ID Must be Greater than 0")]
        public int RunsheetID { get; set; }
        [Required(ErrorMessage = "A Column Is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "The Column must be greater than 0")]
        public int Col { get; set; }
    }

    public class ReportEntryForUpdateDto
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastMod { get; set; }
        [Required(ErrorMessage = "Report Date is Required.")]
        public DateTime ReportDate { get; set; }
        [Required(ErrorMessage = "A Runsheet Is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "The Runsheet ID Must be Greater than 0")]
        public int RunsheetID { get; set; }
        [Required(ErrorMessage = "A Column Is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "The Column must be greater than 0")]
        public int Col { get; set; }
    }
}
