
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;


namespace Data_Layer
{
    public class ADC : IADC
    {
        //Filstreng til de tre afledninger fra Physionet
        //private string _pathLead1 = @"..\..\Lead1.csv";
        //private string _pathLead2 = @"..\..\Lead2.csv";
        //private string _pathLead3 = @"..\..\Lead3.csv";
        
        private string _pathLead1 = @"C:\Users\ina-m\OneDrive\Dokumenter\4. semester\Projekt\Kode\ECG_Measure_System\Data_Layer\Lead1.csv";
        private string _pathLead2 = @"C:\Users\ina-m\OneDrive\Dokumenter\4. semester\Projekt\Kode\ECG_Measure_System\Data_Layer\Lead2.csv";
        private string _pathLead3 = @"C:\Users\ina-m\OneDrive\Dokumenter\4. semester\Projekt\Kode\ECG_Measure_System\Data_Layer\Lead3.csv";
        //Indlæs signal fra Physionet
        public byte[] ReadCsvLead1()
        {
            using (var reader = new StreamReader(_pathLead1))
            {
                List<double> listA = new List<double>();
                var h1 = reader.ReadLine();
                var h2 = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Convert.ToDouble(Double.Parse(values[1].Replace('.', ',')))); 

                }

                byte[] array = listA.SelectMany(BitConverter.GetBytes).ToArray();

                return array;
            }
        }


        public byte[] ReadCsvLead2()
        {
            using (var reader = new StreamReader(_pathLead2))
            {
                List<double> listA = new List<double>();
                var h1 = reader.ReadLine();
                var h2 = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Convert.ToDouble(Double.Parse(values[1].Replace('.', ',')))); 

                }

                byte[] array = listA.SelectMany(BitConverter.GetBytes).ToArray();

                return array;
            }
        }
        public byte[] ReadCsvLead3()
        {
            using (var reader = new StreamReader(_pathLead3))
            {
                List<double> listA = new List<double>();
                var h1 = reader.ReadLine();
                var h2 = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Convert.ToDouble(Double.Parse(values[1].Replace('.', ',')))); 

                }

                byte[] array = listA.SelectMany(BitConverter.GetBytes).ToArray();

                return array;
            }
        }

        //public byte[] ReadCsvLead1()
        //{
        //    //1. Lead
        //    var csvTable1 = new DataTable();
        //    using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(_pathLead1)), true))
        //    {
        //        csvTable1.Load(csvReader);
        //    }
        //    return ConvertDataTableToByteArray(csvTable1);
        //}

        //public byte[] ReadCsvLead2() {
        //    //2. Lead
        //    var csvTable2 = new DataTable();
        //    using (var csvReader2 = new CsvReader(new StreamReader(System.IO.File.OpenRead(_pathLead2)), true))
        //    {
        //        csvTable2.Load(csvReader2);
        //    }
        //    return ConvertDataTableToByteArray(csvTable2);
        //}

        //public byte[] ReadCsvLead3()
        //{
        //    var csvTable3 = new DataTable();
        //    using (var csvReader3 = new CsvReader(new StreamReader(System.IO.File.OpenRead(_pathLead3)), true))
        //    {
        //        csvTable3.Load(csvReader3);
        //    }
        //    return ConvertDataTableToByteArray(csvTable3);
        //}

        //private byte[] ConvertDataTableToByteArray(DataTable dataTableConvert)
        //{
        //    byte[] binaryDataResult = null;
        //    using (MemoryStream memStream = new MemoryStream())
        //    {
        //        BinaryFormatter brFormatter = new BinaryFormatter();
        //        dataTableConvert.RemotingFormat = SerializationFormat.Binary;
        //        brFormatter.Serialize(memStream, dataTableConvert);
        //        binaryDataResult = memStream.ToArray();
        //    }
        //    return binaryDataResult;
        //}
    }
}
