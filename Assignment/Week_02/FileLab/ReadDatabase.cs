using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;


namespace FileLab
{
    public partial class ReadDatabase : Form
    {
        DataTable dataTable;
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        public ReadDatabase()
        {
            InitializeComponent();
        }

        private void ReadDatabase_Load(object sender, EventArgs e)
        {
            txtQuery.Text = "select * from KHACHHANG";
            btnQuerry_Click(sender, e);
        }


        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuerry_Click(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=localhost;Integrated Security=True;Pooling=False"))
            {
                connection.Open();
                command = new SqlCommand(txtQuery.Text, connection);
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dgvResult.DataSource = dataTable;
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            var excelWorkBook = excelApp.Workbooks.Add(Type.Missing);
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            for (int j = 0; j < dataTable.Columns.Count; j++)
                excelApp.Cells[j + 1][1] = dataTable.Columns[j].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    excelApp.Cells[j + 1][i + 2] = dataTable.Rows[i][j].ToString();
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|*.xlsx";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();
            }
        }
    }
}
