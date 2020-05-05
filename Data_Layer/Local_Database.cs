using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer
{
    public class Local_Database : IDatabase
    {
        public bool Send_ECG(string CPRNumber, string Name, string Address, DateTime Date, Byte[] ECGLead1_1, Byte[] ECGLead1_2, Byte[] ECGLead1_3, Byte[] ECGLead2_1, Byte[] ECGLead2_2, Byte[] ECGLead2_3, Byte[] ECGLead3_1, Byte[] ECGLead3_2, Byte[] ECGLead3_3, int Pulse1, int Pulse2, int Pulse3, int HRV1, int HRV2, int HRV3)
        {
            return true;
        }
    }
}
