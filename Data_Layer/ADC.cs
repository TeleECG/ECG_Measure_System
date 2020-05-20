
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
        private string _pathLead1 = @"..\..\Lead1.csv";
        private string _pathLead2 = @"..\..\Lead2.csv";
        private string _pathLead3 = @"..\..\Lead3.csv";

        //private string _pathLead1 = @"C:\Users\Mie\Cloud\MiesTing\Universitet - ST\4.Semester ST\4. Semesterprojekt\Software\ECG_Measure_System\Data_Layer\1Lead.csv";
        //private string _pathLead2 = @"C:\Users\Mie\Cloud\MiesTing\Universitet - ST\4.Semester ST\4. Semesterprojekt\Software\ECG_Measure_System\Data_Layer\2Lead.csv";
        //private string _pathLead3 = @"C:\Users\Mie\Cloud\MiesTing\Universitet - ST\4.Semester ST\4. Semesterprojekt\Software\ECG_Measure_System\Data_Layer\3Lead.csv";
        ////Indlæs signal fra Physionet
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
    }
}
