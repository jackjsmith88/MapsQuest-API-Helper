using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Net.Http;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace MapsQuest_API_Helper
{
    public partial class Form1 : Form
    {

        bool XlValidated = false;

        // A Mini Model to make Serialising the Http Request a little easier
        class MapRequest
        {
            public string location { get; set; }
            public int maxResults { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }


        public int subRegionCol { get; set; }
        public int CountryCol { get; set; }
        public int LatCol { get; set; }
        public int LongCol { get; set; }
        public string APIKey { get; set; }

        //GEOCODE

            //DYNAMICS
        // These methods loop through the used columns of the sheet and return a number representing the column. IE A = 1 / Z = 26
        public int getCountryCol(Range usedRange)
        {
            int result = 0;
            try
            {
                for (int i = 1; i < usedRange.Columns.Count + 1; i++)
                {
                    Range r = usedRange[1, i];
                    if (r.Value == "Country")
                    {
                        result = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                result = 9999;
            }
            return result;
        }
        public int getsubRegionCol(Range usedRange)
        {
            int result = 0;
            try
            {
                for (int i = 1; i < usedRange.Columns.Count + 1; i++)
                {
                    Range r = usedRange[1, i];
                    if (r.Value == "Sub-Region")
                    {
                        result = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                result = 9999;
            }
            return result;
        }
        public int getLatitudeCol(Range usedRange)
        {
            int result = 0;
            try
            {
                for (int i = 1; i < usedRange.Columns.Count + 1; i++)
                {
                    Range r = usedRange[1, i];
                    if (r.Value == "Latitude")
                    {
                        result = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                result = 9999;
            }
            return result;
        }
        public int getLongitudeCol(Range usedRange)
        {
            int result = 0;
            try
            {
                for (int i = 1; i < usedRange.Columns.Count + 1; i++)
                {
                    Range r = usedRange[1, i];
                    if (r.Value == "Longitude")
                    {
                        result = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                result = 9999;
            }
            return result;
        }
        
        //Excel Application session to perform the tasks
        public Microsoft.Office.Interop.Excel.Application ExApp { get; set; } 


        public Workbook XLBook { get; set; }
        public Worksheet XLSht { get; set; }
        public Range XLUsedRange { get; set; } 

        //ensuring this is static is a best practice, this HttpClient doesnt implement "Dispose" therefore leaves connections open. static is good.
        static HttpClient Client = new HttpClient();

        //This Checks to see if there is an exisiting session of Excel running so we dont overuse or instantiate tons of sessions
        public Microsoft.Office.Interop.Excel.Application TryGetExistingExcelApplicationExcel()
        {
            try
            {
                object o = Marshal.GetActiveObject("Excel.Application");

                return (Microsoft.Office.Interop.Excel.Application)o;

            }
            catch (COMException)
            {

                return new Microsoft.Office.Interop.Excel.Application();

            }
        }
        private void btnGetExcelFilePath_Click(object sender, EventArgs e)
        {
            string path = pickFile();
            tbxExcelFilePath.Text = path;
        }

        //Dialog to collect the path of the excel file.
        public string pickFile()
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "Excel Worksheets|*.xlsx";
                OFD.Multiselect = false;

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string file = OFD.FileName;
                    return file;
                }
                else
                {
                    return "No file picked";
                }
            }
        }

        public async Task GeocodeMainOperationFlow()
        {
            //Validation of Excel stuff Fiirst! - Dont waste calls if API needlessly
            await GeoCodeOperationValidation();

            if (XlValidated)
            {
                if (tbxAPIkey.Text == String.Empty)
                {
                    MessageBox.Show("Key looks Empty, please revise?");
                    XLBook.Close(SaveChanges: false);
                    ExApp.Quit();
                    return;
                }
                else
                {
                    if (tbxAPIkey.Text.Length < 30)
                    {
                        MessageBox.Show("That APi key doesn't look right?");
                        XLBook.Close(SaveChanges: false);
                        ExApp.Quit();
                        return;
                    }
                    else
                    {
                        APIKey = tbxAPIkey.Text;

                        //Loop through each row
                        for (int i = 2; i < XLUsedRange.Rows.Count + 1; i++)
                        {
                            //Collect the Cells we want to Read/Write from
                            Range subRegionCell = (Range)XLUsedRange.Cells[i, subRegionCol];
                            Range countryCell = (Range)XLUsedRange.Cells[i, CountryCol];
                            Range latCell = (Range)XLUsedRange.Cells[i, LatCol];
                            Range longCell = (Range)XLUsedRange.Cells[i, LongCol];


                            string subRegionVal = subRegionCell.Value;
                            string countryVal = countryCell.Value;

                            string concat = subRegionVal + "," + countryVal;

                            var Reqest = new MapRequest();

                            Reqest.location = concat;
                            Reqest.maxResults = 1;

                            var json = JsonConvert.SerializeObject(Reqest);
                            var data = new StringContent(json, Encoding.UTF8, "application/json");
                            var url = $"http://open.mapquestapi.com/geocoding/v1/address?key=" + APIKey;
                            var response = await Client.PostAsync(url, data);
                            var result = response.Content.ReadAsStringAsync().Result;

                            //Root is a base class in MapsResponse.Cs, its the anticipated response from MapsQuest GeoCoding Api
                            var receivedModel = JsonConvert.DeserializeObject<Root>(result);

                            try
                            {
                                ExApp.ScreenUpdating = true;
                                ExApp.Visible = true;

                                double lat = receivedModel.results[0].locations[0].latLng.lat;
                                double lng = receivedModel.results[0].locations[0].latLng.lng;

                                latCell.Value = lat;
                                longCell.Value = lng;
                            }
                            catch (Exception ex)
                            {
                                //if it fails close stuff down on prompt.
                                MessageBox.Show("Problem detected at response");
                                MessageBox.Show(ex.Message);
                                var quit = MessageBox.Show("Do you want to Close Excel without saving Changes?", "Quit Excel?", MessageBoxButtons.YesNo);

                                if (quit == DialogResult.Yes)
                                {
                                    ExApp.DisplayAlerts = false;
                                    XLBook.Close(SaveChanges: false);
                                    ExApp.Quit();
                                }
                                break;
                            }


                        }
                    }
                }



            }
        }

        public async Task GeoCodeOperationValidation()
        {
            // This Validates all the Excel Stuff, Opens a book, Denotes the First Worksheet and collects the usedRange.

            //Then it takes the column numbers, either from the inputboxes, or from dynamic mapping, and ensure's the numbers a within 1 - 100 to prevent dodgy or inifinite loops
            string path = tbxExcelFilePath.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("issue with the file path, please try again");
                return;
            }
            else
            {
                var EXApp = TryGetExistingExcelApplicationExcel();

                Workbook XlBook = EXApp.Workbooks.Open(path);

                Worksheet XlSht = XlBook.Worksheets[1];

                Range XlUsedRange = XlSht.UsedRange;

                int _countryCol, _subRegionCol, _latCol, _lngCol;

                try
                {
                    if (tbxColCountry.Text != String.Empty)
                    {
                        if (int.Parse(tbxColCountry.Text) > 0)
                        {
                            _countryCol = int.Parse(tbxColCountry.Text);
                            CountryCol = _countryCol;
                        }
                        else
                        {
                            _countryCol = getCountryCol(XlUsedRange);
                            CountryCol = _countryCol;
                        }
                    }
                    else
                    {
                        _countryCol = getCountryCol(XlUsedRange);
                        CountryCol = _countryCol;
                    }

                    if (tbxColTown.Text != String.Empty)
                    {
                        if (int.Parse(tbxColTown.Text) > 0)
                        {
                            _subRegionCol = int.Parse(tbxColTown.Text);
                            subRegionCol = _subRegionCol;
                        }
                        else
                        {
                            _subRegionCol = getsubRegionCol(XlUsedRange);
                            subRegionCol = _subRegionCol;
                        }
                    }
                    else
                    {
                        _subRegionCol = getsubRegionCol(XlUsedRange);
                        subRegionCol = _subRegionCol;
                    }

                    if (tbxLatitudeCol.Text != String.Empty)
                    {
                        if (int.Parse(tbxLatitudeCol.Text) > 0)
                        {
                            _latCol = int.Parse(tbxLatitudeCol.Text);
                            LatCol = _latCol;
                        }
                        else
                        {
                            _latCol = getLatitudeCol(XlUsedRange);
                            LatCol = _latCol;
                        }
                    }
                    else
                    {
                        _latCol = getLatitudeCol(XlUsedRange);
                        LatCol = _latCol;
                    }

                    if (tbxLongitudeCol.Text != String.Empty)
                    {
                        if (int.Parse(tbxLongitudeCol.Text) > 0)
                        {
                            _lngCol = int.Parse(tbxLongitudeCol.Text);
                            LongCol = _lngCol;
                        }
                        else
                        {
                            _lngCol = getLongitudeCol(XlUsedRange);
                            LongCol = _lngCol;
                        }
                    }
                    else
                    {
                        _lngCol = getLongitudeCol(XlUsedRange);
                        LongCol = _lngCol;
                    }

                    if (LongCol > 0 && LongCol < 100)
                    {
                        if (LatCol > 0 && LatCol < 100)
                        {
                            if (CountryCol > 0 && CountryCol < 100)
                            {
                                if (subRegionCol > 0 && subRegionCol < 100)
                                {
                                    XlValidated = true;
                                }
                            }
                        }
                    }


                    ExApp = EXApp;
                    XLBook = XlBook;
                    XLSht = XlSht;
                    XLUsedRange = XlUsedRange;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Problem collecting information on Excel sheet");
                    return;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await GeocodeMainOperationFlow();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form help = new Help();
            help.Show();
        }
    }
}
