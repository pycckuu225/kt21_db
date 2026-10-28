using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

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
            cmbGroup.Items.Add("основная");
            cmbGroup.Items.Add("подготовительная");
            cmbGroup.Items.Add("специальная");
            cmbGroup.Items.Add("освобождена");
            cmbGroup.SelectedIndex = 0;

            if (currentRow == null)
            {
                return;
            }

            txtSurname.Text = currentRow.Row["Фамилия"].ToString();
            txtName.Text = currentRow.Row["Имя"].ToString();
            txtStreet.Text = currentRow.Row["Улица"].ToString();
            txtHouse.Text = currentRow.Row["Дом"].ToString();
            txtFlat.Text = currentRow.Row["Квартира"].ToString();
            txtClass.Text = currentRow.Row["Класс"].ToString();
            txtHobby.Text = currentRow.Row["Хобби"].ToString();
            chkMale.Checked = Convert.ToBoolean(currentRow.Row["Пол"]);

            object birth = currentRow.Row["Дата рождения"];
            if (birth != DBNull.Value)
            {
                dtpBirth.Value = Convert.ToDateTime(birth);
            }

            string group = currentRow.Row["Группа"].ToString();
            if (!cmbGroup.Items.Contains(group))
            {
                cmbGroup.Items.Add(group);
            }
            cmbGroup.SelectedItem = group;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query;
            if (currentRow == null)
            {
                query = "INSERT INTO Студенты (Фамилия, Имя, [Дата рождения], Пол, Улица, Дом, Квартира, Класс, Группа, Хобби) " +
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            }
            else
            {
                query = "UPDATE Студенты SET Фамилия = ?, Имя = ?, [Дата рождения] = ?, Пол = ?, Улица = ?, " +
                        "Дом = ?, Квартира = ?, Класс = ?, Группа = ?, Хобби = ? WHERE Код = ?";
            }

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("Фамилия", txtSurname.Text);
            command.Parameters.AddWithValue("Имя", txtName.Text);
            command.Parameters.AddWithValue("Дата рождения", dtpBirth.Value.Date);
            command.Parameters.AddWithValue("Пол", chkMale.Checked);
            command.Parameters.AddWithValue("Улица", txtStreet.Text);
            command.Parameters.AddWithValue("Дом", Number(txtHouse.Text));
            command.Parameters.AddWithValue("Квартира", Number(txtFlat.Text));
            command.Parameters.AddWithValue("Класс", txtClass.Text);
            command.Parameters.AddWithValue("Группа", cmbGroup.Text);
            command.Parameters.AddWithValue("Хобби", txtHobby.Text);

            if (currentRow != null)
            {
                command.Parameters.AddWithValue("Код", Convert.ToInt32(currentRow.Row["Код"]));
            }

            command.ExecuteNonQuery();

            if (currentRow == null)
            {
                MessageBox.Show("Строка добавлена!");
            }
            else
            {
                MessageBox.Show("Строка изменена!");
            }

            Close();
        }

        private static object Number(string text)
        {
            if (text.Trim() == "")
            {
                return DBNull.Value;
            }
            return Convert.ToInt32(text);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}