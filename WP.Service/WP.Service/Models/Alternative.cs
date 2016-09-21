using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WP.Service.Models
{
    public class Alternative : BaseModel
    {
        public string Label { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public int Cost { get; set; }
        public DateTime Date { get; set; }
    }
}