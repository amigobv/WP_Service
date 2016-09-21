using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WP.Service.Models
{
    public class Guest : BaseModel
    {
        public string Name { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public Guest Accompanied { get; set; }
        public Prediction Chance { get; set; }
    }
}