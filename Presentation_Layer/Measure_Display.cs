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
        int counter = 0;
        Send_ECG_Controller _send_ECG_Controller;

        public Measure_Display(Send_ECG_Controller send_ECG_Controller)
        {
            _send_ECG_Controller = send_ECG_Controller;
            InitializeComponent();
        }

        private void Start_SendB_Click(object sender, EventArgs e)
        {
            //Dette sker efter tredje måling 
            counter = 3;
            Start_SendB.Text = "Send målinger";

            //Når counter er 3, og målinger skal sendes
            if(counter == 3)
            {
                _send_ECG_Controller.Send_ECG_Measurement_Local();
                bool connectionanswer = _send_ECG_Controller.Send_ECG_Measurement_Tele();
                if (connectionanswer == true)
                {
                    MessageBox.Show("Målingerne er sendt.");
                }
                else
                    //Mangler kode til, hvis den er false og data skal sendes senere fra lokal til tele, når der er forbindelse igen
                    MessageBox.Show("Målingerne er sendt.");
            }

        }

        private void Regret_ECGB_Click(object sender, EventArgs e)
        {
            this.Hide();//Skjuler measure display, således at patient display kommer frem
        }
    }
}
