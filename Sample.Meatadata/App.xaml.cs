using Sample.Meatadata.WindowView;
using Sample.Meatadata.XmlServices;
using System;
using System.IO;
using System.Windows;
using System.Xml;

namespace Sample.Meatadata
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string DirectOpenPath { get; set; }
        public static ObjectTableControl CurrentControl { get; set; }
        public static MainWindowControl MainControl { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            if (e.Args != null && e.Args.Length > 0)
            {
                DirectOpenPath = e.Args[0].ToString();
                if (!string.IsNullOrEmpty(App.DirectOpenPath))
                {
                    FileStream stream = null;
                    try
                    {
                        stream = new FileStream(App.DirectOpenPath, FileMode.Open);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        base.OnStartup(e);
                        return;
                    }

                    try
                    {
                        XmlDocument document = new XmlDocument();
                        document.Load(stream);
                        XmlParser ParserHelper = new XmlParser();
                        ObjectTableViewModel model = ParserHelper.LoadObjectTableData(document);
                        CurrentControl = new ObjectTableControl();
                        CurrentControl.DataContext = model;
                        CurrentControl.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                        CurrentControl.WindowState = WindowState.Maximized;
                        CurrentControl.Show();
                        CurrentControl.Closed += CurrentControl_Closed;
                        stream.Close();
                        stream.Dispose();
                    }

                    catch (Exception err)
                    {
                        if (DirectOpenPath.Contains(".fxml"))
                        {
                            var FileName = Path.GetFileName(DirectOpenPath).Replace(".fxml", "");
                            MainWindowViewModel model = new MainWindowViewModel();
                            model.TableName = FileName;
                            MainControl = new MainWindowControl();
                            MainControl.DataContext = model;
                            MainControl.Show();
                            MainControl.Closed += MainControl_Closed;
                        }
                        else
                        {
                            MessageBox.Show(err.Message);
                        }
                    };
                }
            }
            else
            {
                LoadFileWindow loadFileWindow = new LoadFileWindow();
                loadFileWindow.Show();
            }
            base.OnStartup(e);
        }

        private void MainControl_Closed(object sender, EventArgs e)
        {
            MainControl.Close();
        }
        void CurrentControl_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
