using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TypeReflector.Properties;
using System.ComponentModel;
using Microsoft.Win32;
using System.Data;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Media.Animation;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using DocumentFormat.OpenXml.EMMA;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Threading.Tasks;


namespace TypeReflector
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string dataFromFile, buffer;
        ProgressBar progbar = new ProgressBar();
        public MainWindow()
        {          
            InitializeComponent();
            this.Closed += MainWindow_OnClosed;
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Выясняем, действительно ли пользователь хочет закрыть окно.
            string msg = "\tDo you want to close without saving?\t";
            MessageBoxResult result = MessageBox.Show(msg, "WARNING!!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                //Если пользователь не желает открыть окно, то отменить закрытие
                e.Cancel = true;
            }       
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            //MessageBox.Show("Be well !!");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        public void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void FileExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ToolsClick(object sender, RoutedEventArgs e)
        {

        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FileSave_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxData.Text == "")
            {
                MessageBox.Show("Select file for convert !!!");
                return;
            }
            var saveDlg = new SaveFileDialog { Filter = "TXT Files |*.txt" };
            if (true == saveDlg.ShowDialog())
            {
                try
                {
                    //Загрузить содержимое выбранного файла
                    File.WriteAllText(saveDlg.FileName, textBoxData.Text);
                    MessageBox.Show("\tFile created !!!\t");
                }
                catch
                {
                    MessageBox.Show("\tError create file !!!\t");
                }
            }
            //textBoxData.Clear();
        }

        private void FileConvert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute_2(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void OpenCmdExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void SaveCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void textBoxData_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void inkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {

        }

        private void dataGridXML_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClick_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void dataGridXML_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxData.Clear();
        }

        public void textBoxFrom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxwhere_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBoxOrderby_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBoxSelect_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBoxIn_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBoxBool_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void dataGridXML_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        public void textBoxWhere_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxAssembly_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBoxType_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Post_HTTPCode(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Post_tokenHTTPstring(object sender, RoutedEventArgs e)
        {
            
        }

        private void ConvertTextToXml_Click(object sender, RoutedEventArgs e)
        {
            var openDlg = new OpenFileDialog { Filter = "Text Files |*.pdf" };
            //Был ли клик на кнопке ОК
            if (true == openDlg.ShowDialog())
            {
                Data.strGetPdfFile = openDlg.FileName;
            }
            else return;
            /*DoIndependentWork();
            ConvertTextToXml.ConvTxtToXml();
            void DoIndependentWork()
            {
                textBoxData.Text += "\r\nWorking . . . . . . .\r\n";
            }*/

            //textBoxData.Clear();
            //textBoxData.Text = Data.strStreamXML;
            //textBoxData.TextWrapping = TextWrapping.Wrap;
        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Data.strSetCurrency = cb.SelectedItem.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
      
        }

        private void tbRate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbtwo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbRateTwo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void ConvertTextToYml_Click(object sender, RoutedEventArgs e)
        {
            var openDlg = new OpenFileDialog { Filter = "Text Files |*.pdf" };
            //Был ли клик на кнопке ОК
            if (true == openDlg.ShowDialog())
            {
                Data.strGetPdfFile = openDlg.FileName;
            }
            else return;

            /*ProgressBar progbar = new ProgressBar();
            progbar.IsIndeterminate = false;
            progbar.Orientation = Orientation.Horizontal;
            progbar.Width = 150;
            progbar.Height = 15;
            Duration duration = new Duration(TimeSpan.FromSeconds(10));
            DoubleAnimation doubleanimation = new DoubleAnimation(100.0, duration);
            progbar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);*/

            DoIndependentWork();
            await Task.Factory.StartNew(() => ConverterPDF.ExtractTextFromPdf());
            //await ConverterPDF.ExtractTextFromPdf();
            void DoIndependentWork()
            {
                textBoxData.Text += "\r\nWorking . . . . . . .\r\n";
            }

            textBoxData.Clear();
            textBoxData.Text = Data.strPutTxtFile;
            textBoxData.TextWrapping = TextWrapping.Wrap;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void dataGridGetType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
