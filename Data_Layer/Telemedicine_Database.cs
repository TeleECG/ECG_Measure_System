using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;

namespace Data_Layer
{
    public class Telemedicine_Database : IDatabase
    {
        private SqlConnection _connection;
        private const String _database = "NameHere";

        public Telemedicine_Database()
        {
            _connection = new SqlConnection("data Source=st-i4dab.uni.au.dk;Initial Catalog=" + _database + ";Persist Security Info=True;User ID=" + _database + ";Password=" + _database + "");
        }
        public bool Send_ECG(string CPRNumber, string Name, string Address, DateTime Date, List<double> ECG, int Pulse, int HRV)
        {
            var _ECGData = ECG.ToArray().SelectMany(value => BitConverter.GetBytes(value)).ToArray();

            try
            {
                _connection.Open();

                string insertstringParam =
                    @"INSERT INTO TelemedicineDatabase(CPR, Name, Address, Date, ECG_Measurement, Pulse, HRV) VALUES (@CPRNumber, @Name, @Address, 
                @Date, @ECG, @Pulse, @HRV)";

                using (SqlCommand cmd = new SqlCommand(insertstringParam, _connection))
                {
                    cmd.Parameters.AddWithValue("@CPRNumber", CPRNumber);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@ECG", _ECGData);
                    cmd.Parameters.AddWithValue("@Pulse", Pulse);
                    cmd.Parameters.AddWithValue("@HRV", HRV);
                 
                    cmd.ExecuteNonQuery();
                }

                _connection.Close();
                return true;
            }

            catch (Exception e)
            {
                _connection.Close();
                return false;
            }
        }
    }
}
