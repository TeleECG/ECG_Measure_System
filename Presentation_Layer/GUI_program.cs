using Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public class GUI_program : IForm
    {
        Enter_Patient_Data_Controller _patient_Data_Controller;
        Measure_Display _measure_Display;
        private Send_ECG_Controller _sendEcgController;
        private Measure_ECG_Controller _measureEcgController;

        public GUI_program(Enter_Patient_Data_Controller patient_Data_Controller, Send_ECG_Controller sendEcgController, Measure_ECG_Controller measureEcgController )
        {
            _patient_Data_Controller = patient_Data_Controller;
            _sendEcgController = sendEcgController;
            _measureEcgController = measureEcgController;
        }

        [STAThread]
        public override void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(new Patient_Display(_patient_Data_Controller, new Measure_Display(_sendEcgController, _measureEcgController)));
        }
    }
}
