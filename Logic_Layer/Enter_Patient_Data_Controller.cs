using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer
{
    public class Enter_Patient_Data_Controller
    {
        private Model _model;

        public Enter_Patient_Data_Controller(Model model)
        {
            _model = model;
        }

        public void SavePatientData(string CPRNumber, string Name, string Address)
        {
            _model._CPRNumber = CPRNumber;
            _model._Name = Name;
            _model._Address = Address;
        }
    }
}
