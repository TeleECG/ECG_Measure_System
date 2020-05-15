using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Layer;
using Domain;

namespace Logic_Layer
{
    public class Measure_ECG_Controller
    {
        private Model _Model;
        private IADC _ADC;
        private ICalculator _HRV;
        private ICalculator _puls;
        private R_peak _rPeak;

        public Measure_ECG_Controller(Model model, IADC ADC, ICalculator HRV, ICalculator puls,R_peak rPeak)
        {
            _Model = model;
            _ADC = ADC;
            _HRV = HRV;
            _puls = puls;
            _rPeak = rPeak;
        }

        public void Measure_ECG(int measureNumber)
        {
            if (measureNumber == 1)
            {
               _Model.ECGLeadValues1_1 = _ADC.ReadCsvLead1();
               _Model.ECGLeadValues1_2 = _ADC.ReadCsvLead2();
               _Model.ECGLeadValues1_3 = _ADC.ReadCsvLead3();

               (int, int) values = Begin_Calculate(_ADC.ReadCsvLead1());
               _Model._Pulse1 = values.Item1;
               _Model._HRV1 = values.Item2;
            }

            if (measureNumber == 2)
            {
                _Model.ECGLeadValues2_1 = _ADC.ReadCsvLead1();
                _Model.ECGLeadValues2_2 = _ADC.ReadCsvLead2();
                _Model.ECGLeadValues2_3 = _ADC.ReadCsvLead3();

                (int, int) values = Begin_Calculate(_ADC.ReadCsvLead1());
                _Model._Pulse2 = values.Item1;
                _Model._HRV2 = values.Item2;
            }

            if (measureNumber == 3)
            {
                _Model.ECGLeadValues3_1 = _ADC.ReadCsvLead1();
                _Model.ECGLeadValues3_2 = _ADC.ReadCsvLead2();
                _Model.ECGLeadValues3_3 = _ADC.ReadCsvLead3();

                (int, int) values = Begin_Calculate(_ADC.ReadCsvLead1());
                _Model._Pulse3 = values.Item1;
                _Model._HRV3 = values.Item2;
            }

        }

        public (int, int) Begin_Calculate(byte[] leadArray)
        {
            BitConverter.ToDouble(leadArray, 2);

            List<double> leadList = new List<double>();

            for (int i = 0; i < leadArray.Length; i+=8)
            {
                // convertere til liste af doubles
                leadList.Add(BitConverter.ToDouble(leadArray,i));
            }

            //HRV
            int _hrvValue = Convert.ToInt32(_HRV.Calculate(leadList));

            List<Vertex> rPeakList =  _rPeak.ReturnVertex();
            List<double> peakList = new List<double>();

            for (int i = 0; i < rPeakList.Count; i++)
            {
                foreach (var peak in rPeakList)
                {
                    peakList.Add(1);
                }
            }
            //puls
            int _pulsValue = Convert.ToInt32(_puls.Calculate(peakList));

            return (_pulsValue, _hrvValue);
        }

        public void Delete_ECG(int deleteNumber)
        {
            if (deleteNumber == 1)
            {
                _Model.ECGLeadValues1_1 = null;
                _Model.ECGLeadValues1_2 = null;
                _Model.ECGLeadValues1_3 = null;
            }

            if (deleteNumber == 2)
            {
                _Model.ECGLeadValues2_1 = null;
                _Model.ECGLeadValues2_2 = null;
                _Model.ECGLeadValues2_3 = null;
            }

            if (deleteNumber == 3)
            {
                _Model.ECGLeadValues3_1 = null;
                _Model.ECGLeadValues3_2 = null;
                _Model.ECGLeadValues3_3 = null;
            }
        }
    }
}
