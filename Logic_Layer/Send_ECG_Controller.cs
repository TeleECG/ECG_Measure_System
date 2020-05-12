using Data_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Logic_Layer
{
    public class Send_ECG_Controller
    {
        private Model _model;
        private IDatabase _databaseLocal;
        private IDatabase _databaseTele;

        public Send_ECG_Controller(Model model, IDatabase databaseLocal, IDatabase databaseTele)
        {
            _model = model;
            _databaseLocal = databaseLocal;
            _databaseTele = databaseTele;
        }

        public void Send_ECG_Measurement_Local()
        {
            using (var db = new LocalDBContext()) //Opretter objekt af klassen PatientContext
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                //Opretter objekt af patient og tilføjer de tilhørende attributter
                var PatientMeasurement = new PatientMeasurement(_model._CPRNumber, _model._Name, _model._Address);

                PatientMeasurement.ECGMeasurements[0].ECGLeads[0].ECGLeadValues = _model.ECGLeadValues1_1; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[0].ECGLeads[1].ECGLeadValues = _model.ECGLeadValues1_2; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[0].ECGLeads[2].ECGLeadValues = _model.ECGLeadValues1_3; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[1].ECGLeads[0].ECGLeadValues = _model.ECGLeadValues2_1; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[1].ECGLeads[1].ECGLeadValues = _model.ECGLeadValues2_2; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[1].ECGLeads[2].ECGLeadValues = _model.ECGLeadValues2_3; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[2].ECGLeads[0].ECGLeadValues = _model.ECGLeadValues3_1; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[2].ECGLeads[1].ECGLeadValues = _model.ECGLeadValues3_2; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements[2].ECGLeads[2].ECGLeadValues = _model.ECGLeadValues3_3; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)

                PatientMeasurement.ECGMeasurements[0].Pulse = _model._Pulse1;
                PatientMeasurement.ECGMeasurements[1].Pulse = _model._Pulse2;
                PatientMeasurement.ECGMeasurements[2].Pulse = _model._Pulse3;

                PatientMeasurement.ECGMeasurements[0].HRV = _model._HRV1;
                PatientMeasurement.ECGMeasurements[1].HRV = _model._HRV2;
                PatientMeasurement.ECGMeasurements[2].HRV = _model._HRV3;

                db.PatientMeasurements.Add(PatientMeasurement); //Her tilføjes Patient objektet til BloggingContext
                db.SaveChanges(); //Det gemmes
            }
        }

        public void Send_ECG_Measurement_Tele()
        {
            List<PatientMeasurement> patientMeasurements;
            using (var dbcontext = new LocalDBContext())
            {
                //patientMeasurements = context.PatientMeasurements.Where(patient => patient.CPRNumber == "123456-1243").

                patientMeasurements = dbcontext.PatientMeasurements.
                    Include(patient => patient.ECGMeasurements).
                    ThenInclude(leads => leads.ECGLeads)
                    .ToList();

                using (var telecontext = new TeleDBContext())
                {
                    telecontext.PatientMeasurements.AddRange(patientMeasurements);
                    telecontext.SaveChanges();
                }

                //Her sletter vi målingen i den lokale database
                dbcontext.PatientMeasurements.RemoveRange(patientMeasurements);
            }
        }
    }
}
