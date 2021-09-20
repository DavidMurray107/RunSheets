using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("ReportDataEntry")]
    public class ReportDataEntry
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey(nameof(ReportEntry))]
        public int ReportEntryID { get; set; }
        public ReportEntry ReportEntry { get; set; }
        [ForeignKey(nameof(DataField))]
        public int DataFieldID { get; set; }
        public DataField DataField{ get; set; }
        public decimal Val { get; set; }
        public int Flag { get; set; }
        public string Qualitative { get; set; }
    }
}
