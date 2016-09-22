using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WP.Service.Models
{
    public class Alternative
    {
        public int AlternativeId { get; set; }
        [ConcurrencyCheck, Required]
        public string Label { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        public string Address { get; set; }
        public byte[] Photo { get; set; }
        public int Cost { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("UserRefId")]
        public virtual User User { get; set; }

        public Alternative()
        {
            
        }
    }
}