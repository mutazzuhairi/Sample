using System;
using System.Windows;
using System.Windows.Controls;

namespace Sample.Meatadata.WindowView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowControl : Window
    {
        public MainWindowControl()
        {
            InitializeComponent();
            this.Closing += MainWindowControl_Closing;
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
        void MainWindowControl_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            Environment.Exit(0);
        }
        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            Environment.Exit(0);
        }
    }
}
