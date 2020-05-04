using Logic_Layer;
using System;
using System.Linq;

namespace LocalDatabase
{
    class Program
    {
        static void Main()
        {
            Model _model = new Model();
            using (var db = new PatientContext()) //Opretter objekt af klassen PatientContext
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

                db.PatientMeasurements.Add(PatientMeasurement); //Her tilføjes Patient objektet til BloggingContext
                db.SaveChanges(); //Det gemmes


                //// Read
                //Console.WriteLine("Querying for a blog");
                //var blog = db.Patients
                //    .OrderBy(b => b.PatientId)
                //    .First();

                //// Update
                //Console.WriteLine("Updating the blog and adding a post");
                //blog.CPRNumber = "123456-1234";
                //blog.ECGMeasurements.Add(
                //    new ECGMeasurement
                //    {
                //        Title = "Hello World",
                //        Content = "I wrote an app using EF Core!"
                //    });
                //db.SaveChanges();

                //// Delete
                //Console.WriteLine("Delete the blog");
                //db.Remove(blog);
                //db.SaveChanges();
            }
        }
    }
}
