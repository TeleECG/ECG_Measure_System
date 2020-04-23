using Data_Layer;
using Domain;
using Logic_Layer;
using Presentation_Layer;
using System;

namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public Program()
        {
            //Datalayer
            IADC adc = new ADC();
            IDatabase local_database = new Local_Database();
            IDatabase telemedicine_database = new Telemedicine_Database();

            //Logic layer
            Model model = new Model();
            Enter_Patient_Data_Controller patient_Data_Controller = new Enter_Patient_Data_Controller(model);
            Measure_ECG_Controller measure_ECG_Controller = new Measure_ECG_Controller(model);
            Send_ECG_Controller send_ECG_Controller = new Send_ECG_Controller(model, local_database, telemedicine_database);

            //Domain layer
            ICalculator HRV_calculator = new HRV_Calculator();
            ICalculator pulse_calculator = new Pulse_Calculator();

            //Forms
            Measure_Display measure_Display = new Measure_Display(send_ECG_Controller);
            IForm GUI_program = new GUI_program(patient_Data_Controller, measure_Display);
            GUI_program.Start();


        }

        
    }
}
