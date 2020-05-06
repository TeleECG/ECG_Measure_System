using Data_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Logic_Layer
{
    public class Send_ECG_Controller
    {
        private Model _Model;
        private IDatabase _databaseLocal;
        private IDatabase _databaseTele;

        public Send_ECG_Controller(Model model, IDatabase databaseLocal, IDatabase databaseTele)
        {
            _Model = model;
            _databaseLocal = databaseLocal;
            _databaseTele = databaseTele;
        }

        public void Send_ECG_Measurement_Local()
        {
            _databaseLocal.Send_ECG(_Model._CPRNumber, _Model._Name, _Model._Address, _Model._Date, _Model.ECGLeadValues1_1, _Model.ECGLeadValues1_2, _Model.ECGLeadValues1_3, _Model.ECGLeadValues2_1, _Model.ECGLeadValues2_2, _Model.ECGLeadValues2_3, _Model.ECGLeadValues3_1, _Model.ECGLeadValues3_2, _Model.ECGLeadValues3_3, _Model._Pulse1, _Model._Pulse2, _Model._Pulse3, _Model._HRV1, _Model._HRV2, _Model._HRV3);
            
            Send_ECG_Measurement_Tele();

            while (Send_ECG_Measurement_Tele() == false)
            {
                Send_ECG_Measurement_Tele();
            }
        }

        public bool Send_ECG_Measurement_Tele()
        {
            return _databaseTele.Send_ECG(_Model._CPRNumber, _Model._Name, _Model._Address, _Model._Date, _Model.ECGLeadValues1_1, _Model.ECGLeadValues1_2, _Model.ECGLeadValues1_3, _Model.ECGLeadValues2_1, _Model.ECGLeadValues2_2, _Model.ECGLeadValues2_3, _Model.ECGLeadValues3_1, _Model.ECGLeadValues3_2, _Model.ECGLeadValues3_3, _Model._Pulse1, _Model._Pulse2, _Model._Pulse3, _Model._HRV1, _Model._HRV2, _Model._HRV3);
        }
    }
}
