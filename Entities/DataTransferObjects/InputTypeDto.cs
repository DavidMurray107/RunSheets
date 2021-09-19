using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class InputTypeDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int isVisible { get; set; }
        public int Area { get; set; }
        public IEnumerable<RunsheetDto> Runsheets { get; set; }
    }
}
