
namespace Sample.BLLayer.Extends.ExtendModels
{
    public class MailAdress
    {
        public MailAdress(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
