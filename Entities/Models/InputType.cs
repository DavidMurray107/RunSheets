using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("InputType")]
    public class InputType
    {
        [Key]
        public int ID { get; set; }
        [StringLength(1000, ErrorMessage = "The Title cannot be more than 1000 characters.")]
        public string Title { get; set; }
        public int isVisible { get; set; }
        public int Area { get; set; }
        public ICollection<Runsheet> Runsheets { get; set; }

    }
}
