using CSV_Import_V2.DAL;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Import_V2
{
    public partial class FormDataImport : Form
    {
        //url to download the CSV
        const string url = "https://twtransfer.energytransfer.com/ipost/capacity/operationally-available?f=csv&extension=csv&asset=TW&gasDay=01%2F24%2F2022&cycle=1&searchType=NOM&searchString=&locType=ALL&locZone=ALL";
        //filepath: csv file will be downloaded in the Downloads folder => (Data_yyyy-MM-dd.csv)
        static string filePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\" + @"Data_" + DateTime.Today.ToString("yyyy-MM-dd") + ".csv";

        public FormDataImport()
        {
            InitializeComponent();
        }

        // Form load
        private void FormDataImport_Load(object sender, EventArgs e)
        {
            Save_btn.Enabled = false;
        }

        //// <summary>
        //// Method to download and parse a csv file
        //// </summary>
        public void ParseCSVFile()
        {
            WebClient client = new WebClient();

            byte[] buffer = client.DownloadData(url);

            Stream stream = new FileStream(filePath, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(buffer);
            stream.Close();

            //optional to see data in Notepad
            //Process.Start("Notepad.exe", filePath);
        }

        //// <summary>
        //// Method to get all data from CSV File
        //// </summary>
        public static DataTable GetDataFromCSVFile(string CSVFilePath)
        {
            DataTable csvData = new DataTable();

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(CSVFilePath))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;

                    //Read columns
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn columnData = new DataColumn(column);
                        columnData.AllowDBNull = true;
                        csvData.Columns.Add(columnData);
                    }

                    while (!csvReader.EndOfData)
                    {
                        //Read rows
                        string[] rowData = csvReader.ReadFields();
                        for (int i = 0; i < rowData.Length; i++)
                        {
                            if (rowData[i] == "")
                            {
                                rowData[i] = null;
                            }
                        }
                        csvData.Rows.Add(rowData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " , Couldn't insert data, something is wrong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return csvData;
        }

        //// <summary>
        //// Load/Import CSV File in the gridview
        //// </summary>
        private void Import_btn_Click(object sender, EventArgs e)
        {
            ParseCSVFile();

            DataTable dtNew = new DataTable();
            int ImportedRecord = 0, InvalidItem = 0;

            dtNew = GetDataFromCSVFile(filePath);

            if (Convert.ToString(dtNew.Columns[0]).ToUpper() != "LOC")
            {
                MessageBox.Show("Invalid Items File");
                Save_btn.Enabled = false;
                return;
            }

            if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
            {
                dataGridView1.DataSource = dtNew;
                Save_btn.Enabled = true;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells["Loc"].Value) == "" || row.Cells["Loc_Zn"].Value == null || row.Cells["Loc_Name"].Value == null)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    InvalidItem += 1;
                }
                else
                {
                    ImportedRecord += 1;
                }
            }

            if (dataGridView1.Rows.Count == 0)
            {
                Save_btn.Enabled = false;
                MessageBox.Show("There is no data in this file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //// <summary>
        //// Insert data into DB
        //// </summary>
        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtItem = (DataTable)(dataGridView1.DataSource);
                string Loc, DC, OPC, TSQ, OAC;
                string InsertItemQry = "";
                int count = 0;

                foreach (DataRow dr in dtItem.Rows)
                {
                    Loc = Convert.ToString(dr["Loc"]);
                    DC = Convert.ToString(dr["DC"]);
                    OPC = Convert.ToString(dr["OPC"]);
                    TSQ = Convert.ToString(dr["TSQ"]);
                    OAC = Convert.ToString(dr["OAC"]);

                    if (Loc != "" && dr["Loc Zn"].ToString() != "" && dr["Loc Name"].ToString() != "")
                    {
                        InsertItemQry += "DELETE FROM Shipment WHERE Loc = '" + Loc + "' INSERT INTO Shipment VALUES('" + Loc + "','" + dr["Loc Zn"] + "','" + dr["Loc Name"] + "','" + dr["Loc Purp Desc"] + "','" + dr["Loc/QTI"] + "','" + dr["Flow Ind"] + "','" + DC + "','" + OPC + "','" + TSQ + "','" + OAC + "','" + dr["IT"] + "','" + dr["Auth Overrun Ind"] + "','" + dr["Nom Cap Exceed Ind"] + "','" + dr["All Qty Avail"] + "','" + dr["Qty Reason"] + "'); ";
                        count++;
                    }
                }

                if (InsertItemQry.Length > 5)
                {
                    bool isSuccess = DBAccess.ExecuteQuery(InsertItemQry);

                    if (isSuccess)
                    {
                        MessageBox.Show($"{count} Records Imported Successfully into DB", "Confirmation");
                        //dataGridView1.DataSource = null;
                        //Save_btn.Enabled = false;
                        MessageBox.Show($"Thank you for using the app!", "Confirmation");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Check DB Connection, Something wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
