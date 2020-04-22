using Data_Layer;
using Domain;
using Logic_Layer;
using Presentation_Layer;
using System;

namespace MainApp
{
    class Program
    {
        public Program()
        {
            Model model = new Model();
            Enter_Patient_Data_Controller patient_Data_Controller = new Enter_Patient_Data_Controller(model);
            Measure_ECG_Controller measure_ECG_Controller = new Measure_ECG_Controller(model);
            Send_ECG_Controller send_ECG_Controller = new Send_ECG_Controller(model);

            ICalculator HRV_calculator = new HRV_Calculator();
            ICalculator pulse_calculator = new Pulse_Calculator();

            IADC adc = new ADC();
            IDatabase local_database = new Local_Database();
            IDatabase telemedicine_database = new Telemedicine_Database();

        }

        static void Main(string[] args)
        {


        }
    }
}
