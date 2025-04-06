using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Net.NetworkInformation;


namespace Reloading
{
    public class DataAccess
    {
        public List<shotData> loadShotData(string CartridgeName)
        {


            using (IDbConnection connection = new SqlConnection(ListBindingHelper.CnnVal("SampleDb")))
            {
                var output = connection.Query<shotData>(
                    "SELECT * FROM dbo.shotData WHERE Cartridge LIKE @Cartridge",
                    new { Cartridge = "%" + CartridgeName + "%" }
                    ).ToList();
                if (output.Count == 0)
                {
                    MessageBox.Show("No data found for the given cartridge name.");
                }
                return output;
            }
        }
        public List<string> GetAllCartridgeNames()
        {
           
            using (IDbConnection connection = new SqlConnection(ListBindingHelper.CnnVal("SampleDb")))
            {
                string query = "SELECT DISTINCT Cartridge FROM ShotData";
                return connection.Query<string>(query).ToList();
            }
        }
    }
}