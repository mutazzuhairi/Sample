using System.Windows.Controls;

namespace Sample.Meatadata.WindowView
{
    /// <summary>
    /// Interaction logic for ObjectFieldsControl.xaml
    /// </summary>
    public partial class ObjectFieldsControl : UserControl
    {
        public ObjectFieldsControl()
        {
            InitializeComponent();
        }
        private void FieldName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txtField = sender as TextBox;
            if (!string.IsNullOrEmpty(txtField.Text) && txtField.Text.Contains(" "))
            {
                int oldsele = txtField.SelectionStart;
                txtField.Text = txtField.Text.Replace(" ", "");
                txtField.SelectionStart = oldsele;
            }
        }
    }
}
