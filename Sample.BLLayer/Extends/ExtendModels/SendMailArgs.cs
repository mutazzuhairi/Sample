using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLLayer.Extends.ExtendModels
{
    public class SendMailArgs
    {
        public  string Subject { get; set; }
        public string Body { get; set; }
        public MailAdress From { get; set; }
        public IEnumerable<MailAdress> SendTo { get; set; }
        public IEnumerable<MailAdress> Cc { get; set; }
        public IEnumerable<MailAdress> Bcc { get; set; }
        public MailConfiguration Configuration { get; set; }
    }
}
