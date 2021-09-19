using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models
{
    [Table("SubSection")]
    public class SubSection
    {
        [Key]
        public int ID { get; set; }
        [StringLength(1000, ErrorMessage = "SubSection Name cannot be more than 1000 Characters")]
        public string SubSectionName { get; set; }
        public int SortOrder { get; set; }
        [ForeignKey(nameof(Runsheet))]
        public int RunsheetID { get; set; }
        public Runsheet Runsheet { get; set; }
        public ICollection<DataField> DataFields { get; set; }
    }
}
