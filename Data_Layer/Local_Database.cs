//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//namespace Data_Layer
//{
//    public class Local_Database : IDatabase
//    {
//        public void Send_ECG(string CPRNumber, string Name, string Address, DateTime Date, Byte[] ECGLead1_1, Byte[] ECGLead1_2, Byte[] ECGLead1_3, Byte[] ECGLead2_1, Byte[] ECGLead2_2, Byte[] ECGLead2_3, Byte[] ECGLead3_1, Byte[] ECGLead3_2, Byte[] ECGLead3_3, int Pulse1, int Pulse2, int Pulse3, int HRV1, int HRV2, int HRV3)
//        {
//            //return true;

//            //List<PatientMeasurement> patientMeasurements;
//            //using (var context = new LocalDBContext())
//            //{
//            //    patientMeasurements = context.PatientMeasurements.Where(patient => patient.CPRNumber == "123456-1243").
//            //        Include(patient => patient.ECGMeasurements).
//            //        ThenInclude(leads => leads.ECGLeads)
//            //        .ToList();
//            //    using (var telecontext = new TeleDBContext())
//            //    {
//            //        telecontext.PatientMeasurements.AddRange(patientMeasurements);
//            //        telecontext.SaveChanges();
//            //    }
//            //}
//        }
//    }
//}
