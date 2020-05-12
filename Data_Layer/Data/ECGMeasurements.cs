using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Data
{
    public partial class ECGMeasurements
    {
        public ECGMeasurements()
        {
            ECGLeads = new List<ECGLeads>();
        }

        [Key]
        public int ECGMeasurementId { get; set; } 
        public int PatientMeasurementId { get; set; }
        public int MeasurementNumber { get; set; }
        public int Pulse { get; set; }
        public int HRV { get; set; }

        public virtual PatientMeasurements PatientMeasurement { get; set; }
        public virtual ICollection<ECGLeads> ECGLeads { get; set; }
    }
}
