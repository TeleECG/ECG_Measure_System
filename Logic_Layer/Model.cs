using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Logic_Layer
{
    public class Model
    {
        public string _CPRNumber { get; set; }

        public string _Name { get; set; }

        public string _Address { get; set; }

        public DateTime _Date { get; set; }

        public List<double> _ECG { get; set; }

        public int _Pulse { get; set; }

        public int _HRV { get; set; }

       
    }
}
