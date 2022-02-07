using Sample.BLLayer.Extends.ExtendModels;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLLayer.Extends.ExtendServices.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAsync(
        string subject,
        string body,
        IEnumerable<MailAdress> sendTo  = null,
        MailConfiguration configuration = null,
        IEnumerable<MailAdress> Cc = null,
        IEnumerable<MailAdress> Bcc = null,
        BodyBuilder bodyBuilder = null
   );
    }
}
