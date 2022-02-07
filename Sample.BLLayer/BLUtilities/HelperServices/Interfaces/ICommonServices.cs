using System;
using System.Data;
using System.Threading.Tasks;

namespace Sample.BLLayer.BLUtilities.HelperServices.Interfaces
{
    public interface ICommonServices
    {
        public Task<DataTable> ExecuteSQLQuery(string sqlQuery);
        public bool IsEmailValid(string email);
        public bool IsPhoneNumberValid(string phoneNumber);
    }
}
