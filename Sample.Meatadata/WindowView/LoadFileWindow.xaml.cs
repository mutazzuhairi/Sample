using Sample.Meatadata.XmlServices;
using System;
using System.IO;
using System.Windows;
using System.Xml;

namespace Sample.Meatadata.WindowView
{
    /// <summary>
    /// Interaction logic for LoadFileWindow.xaml
    /// </summary>
    public partial class LoadFileWindow : Window
    {
        public LoadFileWindow()
        {
            InitializeComponent();
            this.Closing += LoadFile_Closing;
        }
        void LoadFile_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            Environment.Exit(0);
        }
        private void btnLoadLxmlFile_Click(object sender, RoutedEventArgs e)
        {
            string projectPath = Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DirectoryInfo solutionDir = System.IO.Directory.GetParent(projectPath);
            string solutionDirectory = solutionDir.FullName;
            string dir = solutionDirectory + @"";
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".fxml";
            dlg.Filter = "FXML files (*.fxml)|*.fxml|All files (*.*)|*.*";
            dlg.InitialDirectory = dir;
            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                FileStream stream = new FileStream(dlg.FileName, FileMode.Open);
                XmlDocument document = new XmlDocument();
                document.Load(stream);
                XmlParser ParserHelper = new XmlParser();
                ParserHelper.LoadObjectTableData(document);
                rtxtFileContent.AppendText(document.OuterXml);
            }
        }
    }
}
