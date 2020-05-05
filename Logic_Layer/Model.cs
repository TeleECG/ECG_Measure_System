using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Logic_Layer
{
    public class Model
    {
        public string _CPRNumber { get; set; }

        public string _Name { get; set; }

        public string _Address { get; set; }

        public DateTime _Date { get; set; }

        public int _Pulse1 { get; set; }
        public int _Pulse2 { get; set; }
        public int _Pulse3 { get; set; }

        public int _HRV1 { get; set; }
        public int _HRV2 { get; set; }
        public int _HRV3 { get; set; }

        public byte[] ECGLeadValues1_1 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues1_2 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues1_3 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues2_1 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues2_2 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues2_3 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues3_1 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues3_2 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues3_3 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
    }
}
