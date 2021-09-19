using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models
{
    [Table("Datafield")]
    public class DataField
    {
        [Key]
        public int ID { get; set; }
        [Required]
        //Mark as Unique in Fluent API creating
        public string Datakey { get; set; }
        [Required]
        [StringLength(1000,ErrorMessage ="Name cannot be more than 1000 characters")]
        public string Name { get; set; }
        [StringLength(1000,ErrorMessage ="Description cannot be more than 1000 characters")]
        public string Description{ get; set; }
        [ForeignKey(nameof(SubSection))]
        public int SubSectionID { get; set; }
        public SubSection SubSection { get; set; }
        public int SortOrder { get; set; }
        [Column(TypeName="decimal(10,4")]
        public decimal MaxValue { get; set; }
        [Column(TypeName="decimal(10,4")]
        public decimal MinValue { get; set; }
        public int isVisible { get; set; }
        [StringLength(1000,ErrorMessage = "CssClass cannot be more than 1000 characters")]
        public string CssClass { get; set; }
    }
}
