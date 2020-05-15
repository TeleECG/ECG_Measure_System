using Data_Layer;
using Domain;
using Logic_Layer;
using Presentation_Layer;
using System;
using Microsoft.EntityFrameworkCore;

namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Datalayer
            IADC adc = new ADC();

            //Domain layer
            ICalculator HRV_calculator = new HRV_Calculator();
            ICalculator pulse_calculator = new Pulse_Calculator();

            //Logic layer
            Model model = new Model();
            Enter_Patient_Data_Controller patient_Data_Controller = new Enter_Patient_Data_Controller(model);
            Measure_ECG_Controller measure_ECG_Controller = new Measure_ECG_Controller(model, adc, HRV_calculator, pulse_calculator);
            Send_ECG_Controller send_ECG_Controller = new Send_ECG_Controller(model);

            //Forms
            IForm GUI_program = new GUI_program(patient_Data_Controller, send_ECG_Controller, measure_ECG_Controller);
            GUI_program.Start();
        }
        public Program()
        {
            
        }

        
    }
}
