using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer
{
    public interface IDatabase
    {
        bool Send_ECG(string CPRNumber, string Name, string Address, DateTime Date, List<double> ECG, int Pulse,
            int HRV);
    }
}
