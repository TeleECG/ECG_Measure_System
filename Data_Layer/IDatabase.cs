using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer
{
    public interface IDatabase
    {
        void Send_ECG(string CPRNumber, string Name, string Address, DateTime Date, List<List<int>> ECG, int Pulse,
            int HRV);
    }
}
