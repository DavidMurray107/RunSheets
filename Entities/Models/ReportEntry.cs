using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("ReportEntry")]
    public class ReportEntry
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastMod { get; set; }
        public DateTime ReportDate { get; set; }
        [ForeignKey(nameof(Runsheet))]
        public int RunsheetID { get; set; }
        public Runsheet Runsheet { get; set; }
        public int Col { get; set; }
        public ICollection<ReportDataEntry> ReportDataEntries { get; set; }
    }
}
