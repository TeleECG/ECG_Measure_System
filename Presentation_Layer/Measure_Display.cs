using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic_Layer;

namespace Presentation_Layer
{
    public partial class Measure_Display : Form
    {
        private int counter = 0;
        readonly Send_ECG_Controller _send_ECG_Controller;
        private Patient_Display _patientDisplay;
        private Measure_ECG_Controller _measureECGController;

        public Measure_Display(Send_ECG_Controller send_ECG_Controller, Patient_Display patientDisplay, Measure_ECG_Controller measureECGController)
        {
            _send_ECG_Controller = send_ECG_Controller;
            _patientDisplay = patientDisplay;
            _measureECGController = measureECGController;
            InitializeComponent();
        }

        private void Start_SendB_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter == 1)
            {
                Start_SendB.Enabled = false;
                _measureECGController.Measure_ECG(1);
                NameMeasureTB.Visible = true;
                Start_SendB.Text = "Start næste måling";
                Regret_ECGB.Text = "Gentag målingen";
                MeasureNumberTB.Text = "1/3";
                Start_SendB.Enabled = true;
            }

            if (counter == 2)
            {
                Start_SendB.Enabled = false;
                _measureECGController.Measure_ECG(2);
                MeasureNumberTB.Text = "2/3";
                Start_SendB.Enabled = true;
            }

            if (counter == 3)
            {
                Start_SendB.Enabled = false;
                _measureECGController.Measure_ECG(3);
                Start_SendB.Text = "Send måling";
                MeasureNumberTB.Text = "3/3";
                Start_SendB.Enabled = true;
            }

            // Hvis man vil sende målingen
            if (counter == 4)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _send_ECG_Controller.Send_ECG_Measurement_Local();
                bool connectionanswer = _send_ECG_Controller.Send_ECG_Measurement_Tele();
                if (connectionanswer == true)
                {
                    MessageBox.Show("Målingerne er sendt.");
                    _patientDisplay.ShowDialog();
                    counter = 0;
                }
                else
                {
                    MessageBox.Show("Målingerne er sendt.");
                    _patientDisplay.ShowDialog();
                    counter = 0;
                }
            }
        }

        private void Regret_ECGB_Click(object sender, EventArgs e)
        {
            // Ny patient
            if (counter == 0)
            {
                _patientDisplay.ShowDialog();
                this.Hide(); //Skjuler measure display, således at patient display kommer frem
            }

            if (counter == 1)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _measureECGController.Delete_ECG(1);
                counter = 0;
                MeasureNumberTB.Clear();
                Regret_ECGB.Text = "Ny patient";
                Start_SendB.Enabled = true;
                Regret_ECGB.Enabled = true;
            }

            if (counter == 2)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _measureECGController.Delete_ECG(2);
                counter = 1;
                MeasureNumberTB.Text = "1/3";
                Start_SendB.Enabled = true;
                Regret_ECGB.Enabled = true;
            }

            if (counter == 3)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _measureECGController.Delete_ECG(3);
                counter = 2;
                MeasureNumberTB.Text = "2/3";
                Start_SendB.Enabled = true;
                Regret_ECGB.Enabled = true;
            }
        }
    }
}
