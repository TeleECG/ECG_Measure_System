using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Data
{
    public partial class ECGLeads
    {
        [Key]
        public int ECGLeadId { get; set; }
        public int ECGMeasurementId { get; set; }
        public int LeadNumber { get; set; }
        public byte[] ECGLeadValues { get; set; }

        public virtual ECGMeasurements ECGMeasurement { get; set; }
    }
}
