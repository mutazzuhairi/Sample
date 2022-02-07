using System.ComponentModel;

namespace Sample.Meatadata.MetadataUtilities.HelperClasses
{
    public class PropertyChangedImplementation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void FirePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                try
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
                catch { }
            }
        }
    }
}
