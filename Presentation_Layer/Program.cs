using Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public class Program //Der stod static først
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        Enter_Patient_Data_Controller _patient_Data_Controller;
        Measure_Display _measure_Display;
        public Program(Enter_Patient_Data_Controller patient_Data_Controller, Measure_Display measure_Display )
        {
            _patient_Data_Controller = patient_Data_Controller;
            _measure_Display = measure_Display;
        }
        [STAThread]
       
        public override void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Patient_Display(_patient_Data_Controller, _measure_Display));
        }
    }
}
