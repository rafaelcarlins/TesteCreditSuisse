using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCreditSuisse.Interface;
using TesteCreditSuisse.Model;
using System.Data;
using System.Data.SqlClient;


namespace TesteCreditSuisse.Business
{
    public class TradeBusiness : ITrade
    {
        SqlConnection conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=CreditSuisse;Trusted_Connection=True;MultipleActiveResultSets=true");

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

        public List<string> tradeCategories(List<Trade> trades)
        {
            List<string> ListTradeCategories = new List<string>();
            foreach (var item in trades)
            {
                string TradeCategories = returnCategories(item);
                ListTradeCategories.Add(TradeCategories);
            }
            
            return ListTradeCategories;
        }
        public string returnCategories(Trade trade)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SP_TradeCategory", conn);
            cmd.Parameters.Add(new SqlParameter("@ClientSector", trade.ClientSector));
            cmd.Parameters.Add(new SqlParameter("@value", trade.Value));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);

            string TradeCategories = "";
            if (dt.Rows.Count > 0)
            {
                TradeCategories = dt.Rows[0][0].ToString();
            }
            else
            {
                TradeCategories = "Not categorized";
            }
            
            return TradeCategories;
        }
        
    }
}
