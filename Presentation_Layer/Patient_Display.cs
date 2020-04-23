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

            //private IDatabase _database; // oprettet adgang til database-klassen hvor CPR-nummer skal gemmes

            //public IndtastPatientdata(IDatabase Database)
            //{
            //    _database = Database;
            //}

            bool CPRCheck = checkCPR(CPR);

            if(CPRCheck = true)
            {
                _patient_controller.SavePatientData(CPR, Name, Adress);
                _measure_display.ShowDialog();
            }
            else if(CPRCheck = false)
            {
                MessageBox.Show("Ugyldigt CPR-nummer. Indtast nyt CPR-nummer.");
            }
            
        }

        public bool checkCPR(string CPR)
        {
            List<int> cprList = new List<int>();
            int value = 48;

            foreach (char character in CPR)
            {
                cprList.Add(Convert.ToInt16(character) - value);
            }

            //Trin 1: Find summen af de første 9 tal i cprnummeret
            int cprSum = (4 * cprList[0] + 3 * cprList[1] + 2 * cprList[2] + 7 * cprList[3] + 6 * cprList[4] +
                          5 * cprList[5] + 4 * cprList[6] + 3 * cprList[7] + 2 * cprList[8]);

            //Trin 2: Del summen med 11. Når der deles med 11, runder den selv ned til et helt tal
            int numberAfterDivision = cprSum / 11;

            //Trin 3: Resultatet af divisionen (tal der er rundet ned) ganges med 11
            int value2 = numberAfterDivision * 11;

            //Trin 4: Til tallet i trin 3, lægges 11 til
            int value3 = value2 + 11;

            //Trin 5: Summen trækkes fra tallet i trin 4
            int numberControl = value3 - cprSum;

            //Trin 6: Kontroller at resultatet fra trin 5 er det samme som det 10. tal i cprnummeret eller 11
            if (numberControl == cprList[9] || numberControl == 11)
            {
                return true;
            }

            return false;
        }

        //public bool tjekForCPRIDatabase(string cpr)
        //{
        //    if (_database.gemCPR(cpr) == true)
        //    {
        //        return true;
        //    }

        //    return false;
        //    //Her kunne der bare stå return _database.gemCPR(cpr);
        //}

    }



}
    

