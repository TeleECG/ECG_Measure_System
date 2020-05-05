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

        public Measure_ECG_Controller(Model model, ADC ADC, HRV_Calculator HRV, Pulse_Calculator puls)
        {
            _Model = model;
            _ADC = ADC;
            _HRV = HRV;
            _puls = puls;
        }

        public void Measure_ECG(int measureNumber)
        {
            if (measureNumber == 1)
            {
               _Model.ECGLeadValues1_1 = _ADC.ReadCsvLead1();
               _Model.ECGLeadValues1_2 = _ADC.ReadCsvLead2();
               _Model.ECGLeadValues1_3 = _ADC.ReadCsvLead3();
               Begin_Calculate(_ADC.ReadCsvLead1());
            }

            if (measureNumber == 2)
            {
                _Model.ECGLeadValues2_1 = _ADC.ReadCsvLead1();
                _Model.ECGLeadValues2_2 = _ADC.ReadCsvLead2();
                _Model.ECGLeadValues2_3 = _ADC.ReadCsvLead3();
                Begin_Calculate(_ADC.ReadCsvLead1());
            }

            if (measureNumber == 3)
            {
                _Model.ECGLeadValues3_1 = _ADC.ReadCsvLead1();
                _Model.ECGLeadValues3_2 = _ADC.ReadCsvLead2();
                _Model.ECGLeadValues3_3 = _ADC.ReadCsvLead3();
                Begin_Calculate(_ADC.ReadCsvLead1());
            }

        }

        public void Begin_Calculate(byte[] leadArray)
        {
            BitConverter.ToDouble(leadArray, 2);

            List<double> leadList = new List<double>();

            for (int i = 2; i < leadArray.Length; i++)
            {
                // convertere til liste af doubles
                leadList.Add(Convert.ToDouble(leadArray[i]));
            }

            //puls
            _Model._Pulse = Convert.ToInt32(_puls.Calculate(leadList));

            //HRV
            _Model._HRV = Convert.ToInt32(_HRV.Calculate(leadList));

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
