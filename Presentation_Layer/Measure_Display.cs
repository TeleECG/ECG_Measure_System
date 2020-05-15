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
        private int counter;
        readonly Send_ECG_Controller _send_ECG_Controller;
        private Measure_ECG_Controller _measureECGController;

        public Measure_Display(Send_ECG_Controller send_ECG_Controller, Measure_ECG_Controller measureECGController)
        {
            _send_ECG_Controller = send_ECG_Controller;
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
                Start_SendB.Text = "Start næste måling";
                Regret_ECGB.Text = "Gentag målingen";
                MeasureLabel.Text = "Måling 1 ud af 3";
                Start_SendB.Enabled = true;
            }

            if (counter == 2)
            {
                Start_SendB.Enabled = false;
                _measureECGController.Measure_ECG(2);
                MeasureLabel.Text = "Måling 2 ud af 3";
                Start_SendB.Enabled = true;
            }

            if (counter == 3)
            {
                Start_SendB.Enabled = false;
                _measureECGController.Measure_ECG(3);
                Start_SendB.Text = "Send måling";
                MeasureLabel.Text = "Måling 3 ud af 3";
                Start_SendB.Enabled = true;
            }

            // Hvis man vil sende målingen
            if (counter == 4)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _send_ECG_Controller.Send_ECG_Measurement_Local();
                _send_ECG_Controller.Send_ECG_Measurement_Tele();
                MessageBox.Show("Målingerne er sendt.");
                counter = 0; 
                this.Hide();
                Start_SendB.Text = "Start måling";
                Regret_ECGB.Text = "Ny patient";
                MeasureLabel.Text = "Måling 0 ud af 3";
                Regret_ECGB.Enabled = true;
                Start_SendB.Enabled = true;
            }
        }

        private void Regret_ECGB_Click(object sender, EventArgs e)
        {
            // Ny patient
            if (counter == 0)
            {
                this.Hide(); //Skjuler measure display, således at patient display kommer frem
            }

            if (counter == 1)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _measureECGController.Delete_ECG(1);
                _measureECGController.Measure_ECG(1);
                MeasureLabel.Text = "Måling 1 ud af 3";
                Regret_ECGB.Text = "Gentag målingen";
                Start_SendB.Enabled = true;
                Regret_ECGB.Enabled = true;
            }

            if (counter == 2)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _measureECGController.Delete_ECG(2);
                _measureECGController.Measure_ECG(2);
                MeasureLabel.Text = "Måling 2 ud af 3";
                Start_SendB.Enabled = true;
                Regret_ECGB.Enabled = true;
            }

            if (counter == 3)
            {
                Regret_ECGB.Enabled = false;
                Start_SendB.Enabled = false;
                _measureECGController.Delete_ECG(3);
                _measureECGController.Measure_ECG(3);
                MeasureLabel.Text = "Måling 3 ud af 3";
                Start_SendB.Enabled = true;
                Regret_ECGB.Enabled = true;
            }
        }
    }
}
