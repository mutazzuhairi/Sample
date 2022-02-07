using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Sample.BLLayer.BLUtilities.SystemConstants;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.BLUtilities.HelperServices
{
    public class CommonServices : ICommonServices
    {
        private readonly IConfiguration _configuration;
        public CommonServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<DataTable> ExecuteSQLQuery(string sqlQuery)
        {
 
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString(BLLayerConstatnts.ConnectionString.SAMPLE);
            SqlDataReader myReader;
            using (SqlConnection connection = new SqlConnection(sqlDataSource))
            {
                connection.Open();
                using (SqlCommand myCommand = new SqlCommand(sqlQuery, connection))
                {
                    myReader = await myCommand.ExecuteReaderAsync();
                    table.Load(myReader);

                    myReader.Close();
                    connection.Close();
                }
            }

            return table;
        }
         

        public bool IsEmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsPhoneNumberValid(string phoneNumber)
        {
            try
            {
                if (phoneNumber.TrimStart('0').Length != 9)
                {
                    return false;
                }
                int.Parse(phoneNumber);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
