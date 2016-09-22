using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WP.Service.Models
{
    public enum PredictionTypes
    {
        PROBABLE,
        PERHAPS,
        UNLIKELY
    }

    public class Prediction
    {
        public int PredictionId { get; set; }
        public PredictionTypes Type { get; set; }
    }
}