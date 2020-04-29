using System;
using System.Linq;

namespace LocalDatabase
{
    class Program
    {
        static void Main()
        {
            using (var db = new BloggingContext()) //Opretter objekt af klassen BloggingContext
            {
                // Create
                Console.WriteLine("Inserting a new blog");

                //Opretter objekt af patient og tilføjer de tilhørende attributter (Disse skal evt. hentes fra model-klassen i logic layer 
                var Patient = new Patient() { CPRNumber = "123456-1234", Name = "Inger", Pulse = 65 };
                var ECGM = new ECGMeasurement(); //Opretter objekt af ECGMeasuremnt
                var ECGLead = new ECGLead(); //Opretter objekt af ECGLead
                var ECGLead1 = new ECGLead(); //Opretter nyt objekt af ECGLead
                var ECGLead2 = new ECGLead(); //Opretter endnu et nyt objekt af ECGLead
                ECGM.Title = "Test"; // Sætter målingens "Title" til noget - eks. målenummer
                ECGLead.LeadNumber = 1; //Sætter hvilket lead der er målt
                ECGLead1.LeadNumber = 2; //Sætter hvilket lead der er målt
                ECGLead2.LeadNumber = 3; //Sætter hvilket lead der er målt
                ECGM.ECGLeads.Add(ECGLead); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGM.ECGLeads.Add(ECGLead1); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                ECGM.ECGLeads.Add(ECGLead2); // Her tilføjes ECGLead objektet til listen af ECGLead i ECGMeasurement
                Patient.ECGMeasurements.Add(ECGM); // Her tilføjes ECGMeasurement objektet til listen af ECGMeasurement i Patient
                db.Add(Patient); //Her tilføjes Patient objektet til BloggingContext
                db.SaveChanges(); //Det gemmes


                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Patients
                    .OrderBy(b => b.PatientId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.CPRNumber = "123456-1234";
                blog.ECGMeasurements.Add(
                    new ECGMeasurement
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}
