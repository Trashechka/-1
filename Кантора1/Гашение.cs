using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
namespace Кантора1
{
    public partial class Гашение : Form
    {
        string fam = "";
        string immortal = "";
        string otchim = "";
        int summ;
        static string serverName = @"DESKTOP-2F416IT";
        static string dbName = "Должен";


        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public Гашение()
        {
            InitializeComponent();
        }
        private void add()
        {
            fam = textBox1.Text;
            immortal = textBox2.Text;
            otchim = textBox4.Text;
            summ = Convert.ToInt32(textBox5.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            string quere = $"select Фамилия, Имя, Отчество from [{comboBox1.Text}]";
            SqlCommand cmd = new SqlCommand(quere, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(Table);
            con.Open();
            SqlCommand insertCommand = new SqlCommand($"UPDATE [{comboBox1.Text}] SET Сумма_задолжности = Сумма_задолжности - {summ} where Фамилия = '{textBox1.Text}' and Имя = '{textBox2.Text}' and Отчество = '{textBox4.Text}'", con);
            if (insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно оплачено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
             Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void abs()
        {
            string sqlQuery = $"SELECT Сумма_задолжности,Статус_долга from [{comboBox1.Text}] where Фамилия = '{textBox1.Text}' and Имя = '{textBox2.Text}' and Отчество = '{textBox4.Text}'";

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox3.Text = reader["Сумма_задолжности"].ToString();
                        label7.Text = "Статус: " + reader["Статус_долга"].ToString();
                    }
                }
                else 
                {
                    textBox3.Text = "";
                    label7.Text = "Статус: ";
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void False()
        {
            // Создание запроса для обновления таблицы CultInst и установки статуса заявки на "Отказано"
            string query = $"update [{comboBox1.Text}] set Статус_долга = 'Оплачено' where Сумма_задолжности = 0 and Фамилия = '{textBox1.Text}' and Имя = '{textBox2.Text}' and Отчество = '{textBox4.Text}'";

            // Создание команды для выполнения запроса
            SqlCommand command = new SqlCommand(query, con);

            try
            {
                // Открытие соединения с базой данных
                con.Open();

                // Выполнение запроса и получение количества затронутых строк
                int rowsAffected = command.ExecuteNonQuery();

                // Закрытие соединения с базой данных
                con.Close();
            }
            catch (Exception ex)
            {
                // Отображение сообщения об ошибке в случае возникновения исключения
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        public void maxmin()
        {
            int максЗначение = 0;

            int n = int.Parse(textBox3.Text);
            int значение = Convert.ToInt32(n);
            if (значение > максЗначение)
            {
                максЗначение = значение;
            }
            int введенноеЗначение = Convert.ToInt32(textBox5.Text);

            if (максЗначение >= введенноеЗначение)
            {
                add();
                abs();
                if (Convert.ToInt32(textBox3.Text) == 0)
                {
                    False();
                    abs();
                }
            }
            else
            {
                MessageBox.Show("Введенное число больше, чем указано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            maxmin();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "")
            {
                abs();
                textBox3.Enabled = true;
                textBox5.Enabled = true;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }
        }

        private void Гашение_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Гашение_Load(object sender, EventArgs e)
        {

        }
    }
}
