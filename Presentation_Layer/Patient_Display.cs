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
        string CPR = "";
        string Name = "";
        string Adress = "";
        Enter_Patient_Data_Controller _patient_controller;
        public Patient_Display(Enter_Patient_Data_Controller patient_controller)
        {
            InitializeComponent();
            _patient_controller = patient_controller;

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
    }
}
