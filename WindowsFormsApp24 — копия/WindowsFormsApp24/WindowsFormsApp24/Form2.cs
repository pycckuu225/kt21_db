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
    public partial class Form2 : Form
    {
        public DataRowView currentRow;
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Группа студентов.mdb";
        private OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (currentRow != null)
            {
                textBox1.Text = currentRow.Row["Код"].ToString();
                textBox2.Text = currentRow.Row["Фамилия"].ToString();
                textBox3.Text = currentRow.Row["Имя"].ToString();
                textBox4.Text = currentRow.Row["Дата рождения"].ToString();
                textBox5.Text = currentRow.Row["Пол"].ToString();
                textBox6.Text = currentRow.Row["Улица"].ToString();
                textBox7.Text = currentRow.Row["Дом"].ToString();
                textBox8.Text = currentRow.Row["Квартира"].ToString();
                textBox9.Text = currentRow.Row["Класс"].ToString();
                textBox10.Text = currentRow.Row["Группа"].ToString();
                textBox11.Text = currentRow.Row["Хобби"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string surname = textBox2.Text;
            string name = textBox3.Text;
            string DR = textBox4.Text;
            bool male = Convert.ToBoolean(textBox5.Text);
            string street = textBox6.Text;
            int house = Convert.ToInt32(textBox7.Text);
            int appart = Convert.ToInt32(textBox8.Text);
            string clas = textBox9.Text;
            string group = textBox10.Text;
            string hobby = textBox11.Text;
            string query = null;
            if (currentRow == null)
            {
                query = "INSERT INTO Студенты (Код, Фамилия, Имя, [Дата рождения], Пол," +
                     "Улица, Дом, Квартира, Класс, Группа, Хобби) VALUES (" + kod + ", '" + surname + "', '" + name + "', '" +
                     DR + "', " + male + ", '" + street + "', " + house + ", " + appart + ", '" + clas + "', '" + group + "', '" +
                     hobby + "')";
            }
            else
            {
                query = $"UPDATE Студенты SET Фамилия = '{surname}', Имя = '{name}' WHERE Код = {kod}";
            }
 
            OleDbCommand comand = new OleDbCommand(query, myConnection);
            comand.ExecuteNonQuery();
            MessageBox.Show("Строка добавлена!");
            Close();
        }
    }
}
