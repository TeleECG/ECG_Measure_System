
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using LumenWorks.Framework.IO.Csv;

namespace Data_Layer
{
    public class ADC : IADC
    {
        //Indlæs signal fra Physionet
        public void ReadCsv()
        {
            //1. Lead
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\ina-m\OneDrive\Dokumenter\4. semester\Projekt\EKG-signaler\1Lead.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            //2. Lead
            var csvTable2 = new DataTable();
            using (var csvReader2 = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\ina-m\OneDrive\Dokumenter\4. semester\Projekt\EKG-signaler\2Lead.csv")), true))
            {
                csvTable2.Load(csvReader2);
            }

            //3. Lead
            var csvTable3 = new DataTable();
            using (var csvReader3 = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\ina-m\OneDrive\Dokumenter\4. semester\Projekt\EKG-signaler\3Lead.csv")), true))
            {
                csvTable3.Load(csvReader3);
            }
        }
    }
}
