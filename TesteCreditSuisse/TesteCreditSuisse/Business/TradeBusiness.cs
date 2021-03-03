using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCreditSuisse.Interface;
using TesteCreditSuisse.Model;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TesteCreditSuisse.Business
{
    public class TradeBusiness : ITrade
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)//MSSQLLocalDB;Initial Catalog=CreditSuisse;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private double _value;
        public double Value 
        {
            get => _value;
            set => _value = value;
        }

        private string _clientSector;
        public string ClientSector 
        {
            get => _clientSector;
            set => _clientSector = value;
        }

        public void addPortfolio(List<Trade> trades)
        {
            var CategoryId = returnCategory();
            SqlCommand com = new SqlCommand("SP_AddPortfolio", conn);
            com.CommandType = CommandType.StoredProcedure;
            foreach (var item in trades)
            {
                com.Parameters.AddWithValue("@Value", item.Value);
                com.Parameters.AddWithValue("@ClientSector", item.ClientSector);
                com.Parameters.AddWithValue("@CategoryId", CategoryId);
            }
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        private int returnCategory()
        {
            return 1;
        }
    }
}
