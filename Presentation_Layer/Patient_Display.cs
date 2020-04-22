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
    public partial class Patient_Display : Form
    {
        private string CPR { get; set; }
        string Name { get; set; }
        string Adress { get; set; }
        Enter_Patient_Data_Controller _patient_controller;
        Measure_Display _measure_display; 
        public Patient_Display(Enter_Patient_Data_Controller patient_controller, Measure_Display measure_Display)
        {
            InitializeComponent();
            _patient_controller = patient_controller;
            _measure_display = measure_Display;

        }

        private void CPRTB_TextChanged(object sender, EventArgs e)
        {
            CPR = CPRTB.Text;
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            Name = NameTB.Text;

        }

        private void AdressTB_TextChanged(object sender, EventArgs e)
        {
            Adress = AdressTB.Text;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            //Maria har kode til at tjekke cpr.

            _patient_controller.SavePatientData(CPR,Name,Adress);
            _measure_display.ShowDialog();

        }
    }
}
