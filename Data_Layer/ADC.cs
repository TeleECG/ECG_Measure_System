
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
        //Filstreng til de tre afledninger fra Physionet
        private string _pathLead1 = @"..\..\Lead1.csv";
        private string _pathLead2 = @"..\..\Lead2.csv";
        private string _pathLead3 = @"..\..\Lead3.csv";

        //Indlæs signal fra Physionet
        public void ReadCsvLead1()
        {
            //1. Lead
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(_pathLead1)), true))
            {
                csvTable.Load(csvReader);
            }
        }

        public void ReadCsvLead2() {
            //2. Lead
            var csvTable2 = new DataTable();
            using (var csvReader2 = new CsvReader(new StreamReader(System.IO.File.OpenRead(_pathLead2)), true))
            {
                csvTable2.Load(csvReader2);
            }
        }

        public void ReadCsvLead3()
        {
            var csvTable3 = new DataTable();
            using (var csvReader3 = new CsvReader(new StreamReader(System.IO.File.OpenRead(_pathLead3)), true))
            {
                csvTable3.Load(csvReader3);
            }
        }
    }
}
