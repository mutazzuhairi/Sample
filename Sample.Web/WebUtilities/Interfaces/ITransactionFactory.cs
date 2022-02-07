using System;
using System.Transactions;

namespace Sample.Web.WebUtilities.Interfaces
{
    public interface ITransactionFactory
    {
        public TransactionScope GetTransaction(TimeSpan? timeOut = null);
        public TransactionScope GetAsyncTransaction(TimeSpan? timeOut = null);

    }
}
