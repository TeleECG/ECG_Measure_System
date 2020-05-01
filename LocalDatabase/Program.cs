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
                //Opretter objekt af patient og tilføjer de tilhørende attributter (Disse skal evt. hentes fra model-klassen i logic layer 
                var PatientMeasurement = new PatientMeasurement() { CPRNumber = _model._CPRNumber, Name = _model._Name, Address=_model._Address, Pulse=_model._Pulse, HRV=_model._HRV };
                var ECGMeasurement1 = new ECGMeasurement(); //Opretter objekt af ECGMeasuremnt
                var ECGMeasurement2 = new ECGMeasurement(); //Opretter objekt af ECGMeasuremnt
                var ECGMeasurement3 = new ECGMeasurement(); //Opretter objekt af ECGMeasuremnt
                var ECGLead1_1 = new ECGLead() {ECGLeadValues=_model.ECGLeadValues }; //Opretter objekt af ECGLead
                var ECGLead2_1 = new ECGLead(); //Opretter nyt objekt af ECGLead
                var ECGLead3_1 = new ECGLead(); //Opretter endnu et nyt objekt af ECGLead
                var ECGLead1_2 = new ECGLead(); //Opretter objekt af ECGLead
                var ECGLead2_2 = new ECGLead(); //Opretter nyt objekt af ECGLead
                var ECGLead3_2 = new ECGLead(); //Opretter endnu et nyt objekt af ECGLead
                var ECGLead1_3 = new ECGLead(); //Opretter objekt af ECGLead
                var ECGLead2_3 = new ECGLead(); //Opretter nyt objekt af ECGLead
                var ECGLead3_3 = new ECGLead(); //Opretter endnu et nyt objekt af ECGLead
                ECGLead1_1.LeadNumber = 1; //Sætter hvilket lead der er målt
                ECGLead2_1.LeadNumber = 2; //Sætter hvilket lead der er målt
                ECGLead3_1.LeadNumber = 3; //Sætter hvilket lead der er målt
                ECGLead1_2.LeadNumber = 1; //Sætter hvilket lead der er målt
                ECGLead2_2.LeadNumber = 2; //Sætter hvilket lead der er målt
                ECGLead3_2.LeadNumber = 3; //Sætter hvilket lead der er målt
                ECGLead1_3.LeadNumber = 1; //Sætter hvilket lead der er målt
                ECGLead2_3.LeadNumber = 2; //Sætter hvilket lead der er målt
                ECGLead3_3.LeadNumber = 3; //Sætter hvilket lead der er målt
                ECGMeasurement1.ECGLeads.Add(ECGLead1_1); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement1.ECGLeads.Add(ECGLead2_1); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement1.ECGLeads.Add(ECGLead3_1); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement2.ECGLeads.Add(ECGLead1_2); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement2.ECGLeads.Add(ECGLead2_2); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement2.ECGLeads.Add(ECGLead3_2); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement3.ECGLeads.Add(ECGLead1_3); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement3.ECGLeads.Add(ECGLead2_3); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGMeasurement3.ECGLeads.Add(ECGLead3_3); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement

                PatientMeasurement.ECGMeasurements.Add(ECGMeasurement1); // Her tilføjes ECGMeasurement objektet til listen af ECGMeasurement i Patient
                PatientMeasurement.ECGMeasurements.Add(ECGMeasurement2); // Her tilføjes ECGMeasurement objektet til listen af ECGMeasurement i Patient
                PatientMeasurement.ECGMeasurements.Add(ECGMeasurement3); // Her tilføjes ECGMeasurement objektet til listen af ECGMeasurement i Patient

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
