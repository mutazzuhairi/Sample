using System;
using System.Windows;
using System.Windows.Controls;

namespace Sample.Meatadata.WindowView
{
    /// <summary>
    /// Interaction logic for ObjectTableControl.xaml
    /// </summary>
    public partial class ObjectTableControl : Window
    {
        public ObjectTableControl()
        {
            InitializeComponent();
            this.Closing += ObjectTableControl_Closing;
        }

        void ObjectTableControl_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CancelButtonConfirmationMessage();
        }
        private void TableName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txtField = sender as TextBox;
            if (!string.IsNullOrEmpty(txtField.Text) && txtField.Text.Contains(" "))
            {
                int oldsele = txtField.SelectionStart;
                txtField.Text = txtField.Text.Replace(" ", "");
                txtField.SelectionStart = oldsele;
            }
        }
        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            CancelButtonConfirmationMessage();
        }


        private void CancelButtonConfirmationMessage()
        {
            ObjectTableViewModel viewModel = this.DataContext as ObjectTableViewModel;
            MessageBoxResult result = MessageBox.Show("Do you want to save your changes?", "Save Changes", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                viewModel.SaveChanges();
            }
            else
            {
                if (result != MessageBoxResult.Cancel)
                {
                    Environment.Exit(0);
                    this.Close();
                }
            }
        }
    }
}
