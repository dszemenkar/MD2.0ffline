using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MD2._0ffline.Data
{
    public class Note : BaseEntity
    {
        
        [Required]
        [DisplayName("Notering")]
        public string EntryText { get; set; }
        [DisplayName("Användare")]
        public string User { get; set; }
    }
}
