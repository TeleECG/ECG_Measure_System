using Data_Layer;
using System;
using System.Collections.Generic;
using System.Text;

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

        public bool Send_ECG_Measurement_Local()
        {
            return _databaseLocal.Send_ECG(_Model._CPRNumber,_Model._Name,_Model._Address,_Model._Date,_Model._ECG,_Model._Pulse,_Model._HRV);
        }

        public bool Send_ECG_Measurement_Tele()
        {
            return _databaseTele.Send_ECG(_Model._CPRNumber, _Model._Name, _Model._Address, _Model._Date, _Model._ECG, _Model._Pulse, _Model._HRV);
        }
    }
}
