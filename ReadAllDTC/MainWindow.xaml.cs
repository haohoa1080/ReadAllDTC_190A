using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
namespace ReadAllDTC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Process myProcess = null;
        string newline = Environment.NewLine;
        public MainWindow()
        {
            InitializeComponent();
            FormLoad();
        }
        public void FormLoad()
        {
            InitialPathLoad();
        }
        public void InitialPathLoad()
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }

        public void ProcessList()
        {
            string textOutput = "";
            try
            {
                var buffer = System.IO.File.ReadAllBytes(@txtTextPath.Text);
                txtInput.Text = HexDump(buffer);
                string[] inputFromSource = HexDump(buffer, 1).Split(new char[] { '\n' });
                for (int i = 0; i < inputFromSource.Length; i++)
                {

                    //output print
                    int j = i - 3;
                    if (j >= 0)
                    {

                        string strInput = inputFromSource[i];
                        if (strInput != "")
                            textOutput += strInput.Substring(0, 2);
                        if (j % 4 == 3)
                            textOutput += newline;
                        if (j % 4 == 2)
                            textOutput += "\t";
                    }
                }
                txtOutput.Text = textOutput;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please insert input file");
            }

        }

        public static string HexDump(byte[] bytes, int bytesPerLine = 8)
        {
            if (bytes == null) return "<null>";
            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn = 0;

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - Environment.NewLine.Length) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            return result.ToString();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            ProcessList();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            ProcessList();
            Excel.Application xcelApp = new Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            xcelApp.Cells.NumberFormat = "@";
            string[] strRow = txtOutput.Text.ToString().Split('\n');
            for (int i = 0; i < strRow.Length; i++)
            {
                int nRow = i + 1;
                if (strRow[i] != "")
                {
                    string[] strCol = strRow[i].Split('\t');
                    xcelApp.Cells[nRow, 1] = strCol[0];
                    xcelApp.Cells[nRow, 2] = strCol[1];
                }
            }
            //xcelApp.Cells[1,1] = "abc";

            xcelApp.Visible = true;
        }
        private void txtTextPath_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTextPath_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (files != null && files.Length > 0)
                {
                    ((TextBox)sender).Text = files[0];
                }
            } 
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            string Information = "Version: 1.0";
            Information += "\nAuthor: Banh Vi Hao (RBVH/EPS23)";
            Information += "\nNothing is perfect, if any bug, feel free to contact me: hao.banhvi@vn.bosch.com";
            MessageBox.Show(Information);
        }
    }
}
