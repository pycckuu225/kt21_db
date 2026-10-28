using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp24
{

    public partial class Form1 : Form
    {
        
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Группа студентов.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "группа_студентовDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.группа_студентовDataSet.Студенты);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Студенты WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Элемент удален!");
            this.студентыTableAdapter.Fill(this.группа_студентовDataSet.Студенты);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Fill(this.группа_студентовDataSet.Студенты);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.currentRow = null;
            f.Text = "Добавление";
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.currentRow = студентыBindingSource.Current as DataRowView;
            f.Text = "Редактирование";
            f.Show();
        }

        private void поискПоФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Owner = this;
            f.s = "Введите фамилию";
            f.Show();
        }

        private void поискПоНомеруДомаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Owner = this;
            f.s = "Введите номер дома";
            f.Show();
        }
    }
}
