﻿using Data_Layer.Data;
using Data_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace Logic_Layer
{
    public class Send_ECG_Controller
    {
        private Model _model;
        //private IDatabase _databaseLocal;
        //private IDatabase _databaseTele;

        public Send_ECG_Controller(Model model /*IDatabase databaseLocal, IDatabase databaseTele*/)
        {
            _model = model;
            //_databaseLocal = databaseLocal;
            //_databaseTele = databaseTele;
        }

        public void Send_ECG_Measurement_Local()
        {
            using (var db = new LocalDBContext()) //Opretter objekt af klassen PatientContext
            {
                // Create
                //Console.WriteLine("Tilføjer data til lokal database");

                //Opretter objekt af patient og tilføjer de tilhørende attributter
                var PatientMeasurement = new PatientMeasurements();


                PatientMeasurement.ECGMeasurements = new List<ECGMeasurements>();
                PatientMeasurement.CPRNumber = _model._CPRNumber;
                PatientMeasurement.Name = _model._Name;
                PatientMeasurement.Address = _model._Address;
                PatientMeasurement.Date = DateTime.Now;

                // Der oprettes 3 tomme ECGmålinger som hver har 3 leads (tomme endnu)
                for (int i = 1; i < 4; i++)
                {
                    var p = new ECGMeasurements();
                    p.MeasurementNumber = i;
                    PatientMeasurement.ECGMeasurements.Add(p);
                    
                    for (int x = 1; x < 4; x++)
                    {
                        var t = new ECGLeads();
                        t.LeadNumber = x;
                        p.ECGLeads.Add(t);

                    }
                }

                //Værdier lægges i de 3 leads til hver af de 3 målinger
                PatientMeasurement.ECGMeasurements.ElementAt(0).ECGLeads.ElementAt(0).ECGLeadValues = _model.ECGLeadValues1_1; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements.ElementAt(0).ECGLeads.ElementAt(1).ECGLeadValues = _model.ECGLeadValues1_2; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements.ElementAt(0).ECGLeads.ElementAt(2).ECGLeadValues = _model.ECGLeadValues1_3; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements.ElementAt(1).ECGLeads.ElementAt(0).ECGLeadValues = _model.ECGLeadValues2_1; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                PatientMeasurement.ECGMeasurements.ElementAt(1).ECGLeads.ElementAt(1).ECGLeadValues = _model.ECGLeadValues2_2;
                PatientMeasurement.ECGMeasurements.ElementAt(1).ECGLeads.ElementAt(2).ECGLeadValues = _model.ECGLeadValues2_3;
                PatientMeasurement.ECGMeasurements.ElementAt(2).ECGLeads.ElementAt(0).ECGLeadValues = _model.ECGLeadValues3_1;
                PatientMeasurement.ECGMeasurements.ElementAt(2).ECGLeads.ElementAt(1).ECGLeadValues = _model.ECGLeadValues3_2;
                PatientMeasurement.ECGMeasurements.ElementAt(2).ECGLeads.ElementAt(2).ECGLeadValues = _model.ECGLeadValues3_3;

                PatientMeasurement.ECGMeasurements.ElementAt(0).Pulse = _model._Pulse1;
                PatientMeasurement.ECGMeasurements.ElementAt(1).Pulse = _model._Pulse2;
                PatientMeasurement.ECGMeasurements.ElementAt(2).Pulse = _model._Pulse3;

                PatientMeasurement.ECGMeasurements.ElementAt(0).HRV = _model._HRV1;
                PatientMeasurement.ECGMeasurements.ElementAt(1).HRV = _model._HRV2;
                PatientMeasurement.ECGMeasurements.ElementAt(2).HRV = _model._HRV3;

                db.PatientMeasurements.Add(PatientMeasurement); //Her tilføjes Patient objektet til BloggingContext
                db.SaveChanges(); //Data gemmes i den lokale database


                //kan ikke indeksere med [] i Icollection
                //PatientMeasurement.ECGMeasurements[1].ECGLeads[1].ECGLeadValues = _model.ECGLeadValues2_2; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                //PatientMeasurement.ECGMeasurements[1].ECGLeads[2].ECGLeadValues = _model.ECGLeadValues2_3; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                //PatientMeasurement.ECGMeasurements[2].ECGLeads[0].ECGLeadValues = _model.ECGLeadValues3_1; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                //PatientMeasurement.ECGMeasurements[2].ECGLeads[1].ECGLeadValues = _model.ECGLeadValues3_2; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)
                //PatientMeasurement.ECGMeasurements[2].ECGLeads[2].ECGLeadValues = _model.ECGLeadValues3_3; // List af double skal konverteres til byte (Listen af double, da vi konverterede csv-filen)

            }
        }

        public void Send_ECG_Measurement_Tele()
        {
            List<PatientMeasurements> patientMeasurements;

            using (var dbcontext = new LocalDBContext())
            {
                //patientMeasurements = context.PatientMeasurements.Where(patient => patient.CPRNumber == "123456-1243").

                //Hvad betyder =>?
                patientMeasurements = dbcontext.PatientMeasurements.Include(patient => patient.ECGMeasurements).ThenInclude(leads => leads.ECGLeads).ToList();

                using (var telecontext = new F20ST4PRJ4TeleMedDatabaseContext())
                {
                    telecontext.PatientMeasurements.AddRange(patientMeasurements);
                    telecontext.SaveChanges();
                }

                //Her sletter vi målingen i den lokale database
                //dbcontext.PatientMeasurements.RemoveRange(patientMeasurements);
            }
        }
    }
}
