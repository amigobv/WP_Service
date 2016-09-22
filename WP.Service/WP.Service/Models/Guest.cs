using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WP.Service.Models
{
    public class Guest
    {
        public int GuestId { get; set; }
        [ConcurrencyCheck, Required]
        public string Name { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        [ForeignKey("AccopaniedId")]
        public Guest Accompanied { get; set; }
        [ForeignKey("PredictionRefId")]
        public Prediction Chance { get; set; }

        public Guest()
        {
            
        }
    }
}