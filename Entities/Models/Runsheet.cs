using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Runsheet")]
    public class Runsheet
    {
        [Key]
        public int ID { get; set; }
        [StringLength(1000,ErrorMessage ="Sheet Name Cannot be more than 1000 characters")]
        public string SheetName { get; set; }
        [StringLength(1000, ErrorMessage = "Sheet Key Cannot be more than 1000 characters")]
        public string SheetKey { get; set; }

        public int SortOrder { get; set; }
        [ForeignKey(nameof(InputType))]
        [Required(ErrorMessage = "Assign the Runsheet to an InputType")]
        public int InputTypeID { get; set; }
        public InputType InputType { get; set; }
        public ICollection<SubSection> SubSections { get; set; }

    }
}
