using System;

namespace Sample.BLLayer.Extends.ExtendModels
{
    public class MailException : Exception
    {
        public MailException()
        {

        }

        public MailException(string message) : base(message)
        {

        }

        public MailException(Exception e) : base(e.Message)
        {

        }
    }
}
