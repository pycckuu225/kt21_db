using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form4 : Form
    {
        public string sql;
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Группа студентов.mdb";
        private OleDbConnection myConnection;

        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, myConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}