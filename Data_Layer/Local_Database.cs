using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer
{
    public class Local_Database : IDatabase
    {
        //SQLite skal bruges i den lokale database
        public void Send_ECG(string CPRNumber, string Name, string Address, DateTime Date, List<List<int>> ECG, int Pulse, int HRV)
        {
           
        }
    }
}
