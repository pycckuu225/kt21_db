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
            f.ShowDialog();
            this.студентыTableAdapter.Fill(this.группа_студентовDataSet.Студенты);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.currentRow = студентыBindingSource.Current as DataRowView;
            f.Text = "Редактирование";
            f.ShowDialog();
            this.студентыTableAdapter.Fill(this.группа_студентовDataSet.Студенты);
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

        private void ShowQuery(string title, string query)
        {
            Form4 f = new Form4();
            f.Owner = this;
            f.Text = title;
            f.sql = query;
            f.Show();
        }

        private void запрос1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Родились в 2001 году", "SELECT Фамилия, Имя FROM Студенты WHERE Year([Дата рождения]) = 2001");
        }

        private void запрос2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Улица Пушкина", "SELECT Фамилия, Имя FROM Студенты WHERE Улица LIKE '%Пушкин%'");
        }

        private void запрос3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Дом меньше 50", "SELECT Фамилия, Имя FROM Студенты WHERE Дом < 50");
        }

        private void запрос4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Квартира меньше 12", "SELECT Фамилия, Имя FROM Студенты WHERE Квартира < 12");
        }

        private void запрос5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Мужские имена", "SELECT Фамилия, Имя FROM Студенты WHERE Пол = True");
        }

        private void запрос6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Фамилия на С", "SELECT Фамилия, Имя FROM Студенты WHERE Фамилия LIKE 'С%'");
        }

        private void запрос7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Фамилия на Е, имя на Н", "SELECT Фамилия, Имя FROM Студенты WHERE Фамилия LIKE 'Е%' AND Имя LIKE 'Н%'");
        }

        private void запрос8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Не занимаются тяжелой атлетикой", "SELECT Фамилия, Имя FROM Студенты WHERE Хобби IS NULL OR Хобби NOT LIKE '%тяжел%'");
        }

        private void запрос9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Родились в 2004 году", "SELECT Фамилия, Имя FROM Студенты WHERE Year([Дата рождения]) = 2004");
        }

        private void запрос10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Родились сегодня", "SELECT Фамилия, Имя FROM Студенты WHERE [Дата рождения] = Date()");
        }

        private void запрос11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuery("Без хобби", "SELECT Фамилия, Имя FROM Студенты WHERE Хобби IS NULL OR Хобби = ''");
        }
    }
}
