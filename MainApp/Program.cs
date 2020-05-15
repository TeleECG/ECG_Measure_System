using Data_Layer;
using Domain;
using Logic_Layer;
using Presentation_Layer;
using System;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;
using System.Collections.Generic;

namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Datalayer
            IADC adc = new ADC();

            //Domain layer
            List<double> measure = new List<double>();
            ICalculator HRV_calculator = new HRV_Calculator();
            ICalculator pulse_calculator = new Pulse_Calculator();
            R_peak rPeak = new R_peak(measure);

            //Logic layer
            Model model = new Model();
            Enter_Patient_Data_Controller patient_Data_Controller = new Enter_Patient_Data_Controller(model);
            Measure_ECG_Controller measure_ECG_Controller = new Measure_ECG_Controller(model, adc, HRV_calculator, pulse_calculator,rPeak);
            Send_ECG_Controller send_ECG_Controller = new Send_ECG_Controller(model/*, local_database, telemedicine_database*/);

            //Forms
            IForm GUI_program = new GUI_program(patient_Data_Controller, send_ECG_Controller, measure_ECG_Controller);
            GUI_program.Start();
        }

    }
}
