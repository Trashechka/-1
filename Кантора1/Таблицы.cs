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
    public partial class Таблицы : Form
    {
        string fam;
        static string serverName = @"DESKTOP-2F416IT";
        static string dbName = "Должен";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public Таблицы()
        {
            InitializeComponent();
            c();
            a();
            b();
            f();
            g();
           
        }

        public void c()
        {
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Номер_телефона", "Номер телефона");
            dataGridView1.Columns.Add("Паспортные_данные", "Паспортные данные");
            dataGridView1.Columns.Add("Адрес_прописки", "Адрес прописки");
            dataGridView1.Columns.Add("Сумма_задолжности", "Сумма задолжности");
            dataGridView1.Columns.Add("Статус_долга", "Статус долга");
            dataGridView1.Columns.Add("Логин", "Логин");
        }
        public void a()
        {
            dataGridView2.Columns.Add("Фамилия", "Фамилия");
            dataGridView2.Columns.Add("Имя", "Имя");
            dataGridView2.Columns.Add("Отчество", "Отчество");
            dataGridView2.Columns.Add("Номер_телефона", "Номер телефона");
            dataGridView2.Columns.Add("Паспортные_данные", "Паспортные данные");
            dataGridView2.Columns.Add("Адрес_прописки", "Адрес прописки");
            dataGridView2.Columns.Add("Сумма_задолжности", "Сумма задолжности");
            dataGridView2.Columns.Add("Статус_долга", "Статус долга");
            dataGridView2.Columns.Add("Логин", "Логин");
        }
        public void b()
        {
            dataGridView3.Columns.Add("Фамилия", "Фамилия");
            dataGridView3.Columns.Add("Имя", "Имя");
            dataGridView3.Columns.Add("Отчество", "Отчество");
            dataGridView3.Columns.Add("Номер_телефона", "Номер телефона");
            dataGridView3.Columns.Add("Паспортные_данные", "Паспортные данные");
            dataGridView3.Columns.Add("Адрес_прописки", "Адрес прописки");
            dataGridView3.Columns.Add("Сумма_задолжности", "Сумма задолжности");
            dataGridView3.Columns.Add("Статус_долга", "Статус долга");
            dataGridView3.Columns.Add("Логин", "Логин");
        }
        public void f()
        {
            dataGridView4.Columns.Add("Фамилия", "Фамилия");
            dataGridView4.Columns.Add("Имя", "Имя");
            dataGridView4.Columns.Add("Отчество", "Отчество");
            dataGridView4.Columns.Add("Номер_телефона", "Номер телефона");
            dataGridView4.Columns.Add("Паспортные_данные", "Паспортные данные");
            dataGridView4.Columns.Add("Адрес_прописки", "Адрес прописки");
            dataGridView4.Columns.Add("Сумма_задолжности", "Сумма задолжности");
            dataGridView4.Columns.Add("Статус_долга", "Статус долга");
            dataGridView4.Columns.Add("Логин", "Логин");
        }
        public void g()
        {
            dataGridView5.Columns.Add("Фамилия", "Фамилия");
            dataGridView5.Columns.Add("Имя", "Имя");
            dataGridView5.Columns.Add("Отчество", "Отчество");
            dataGridView5.Columns.Add("Номер_телефона", "Номер телефона");
            dataGridView5.Columns.Add("Паспортные_данные", "Паспортные данные");
            dataGridView5.Columns.Add("Адрес_прописки", "Адрес прописки");
            dataGridView5.Columns.Add("Сумма_задолжности", "Сумма задолжности");
            dataGridView5.Columns.Add("Статус_долга", "Статус долга");
            dataGridView5.Columns.Add("Логин", "Логин");
        }
        private void p(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8));
        }
        private void d(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from SovBanck";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void h(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from TirSbanck";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void j(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from My_Bank";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void k(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Vogue";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void m(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Rosselkhoz";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p(dgw, reader);
            }
            reader.Close();
            con.Close();
        }

        private void Таблицы_Load(object sender, EventArgs e)
        {

        }
        public void ydal()
        {
            string a = comboBox1.SelectedItem.ToString();
            switch (a)
            {
                case "SovBanck":

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable Table = new DataTable();
                    string quere = $"select * from SovBanck";
                    SqlCommand cmd = new SqlCommand(quere, con);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(Table);
                    con.Open();
                    SqlCommand insertCommand = new SqlCommand($"DELETE FROM SovBanck WHERE Паспортные_данные = '{textBox1.Text}'", con);
                    if (insertCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Задолжник успешно удалён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Такого задолжника не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                    break;
                case "My Bank":
                    fam = textBox1.Text;
                    SqlDataAdapter adapte = new SqlDataAdapter();
                    DataTable Tabl = new DataTable();
                    string quer = $"select * from My_Bank";
                    SqlCommand cm = new SqlCommand(quer, con);
                    adapte.SelectCommand = cm;
                    adapte.Fill(Tabl);
                    con.Open();
                    SqlCommand insertComman = new SqlCommand($"DELETE FROM My_Bank WHERE Паспортные_данные = '{textBox1.Text}'", con);
                    if (insertComman.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Задолжник успешно удалён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Такого задолжника не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                    break;
                case "TirSbanck":
                    fam = textBox1.Text;
                    SqlDataAdapter adapt = new SqlDataAdapter();
                    DataTable Tab = new DataTable();
                    string que = $"select * from SovBanck";
                    SqlCommand cms = new SqlCommand(que, con);
                    adapt.SelectCommand = cms;
                    adapt.Fill(Tab);
                    con.Open();
                    SqlCommand insertComma = new SqlCommand($"DELETE FROM TirSbanck WHERE Паспортные_данные = '{textBox1.Text}'", con);
                    if (insertComma.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Задолжник успешно удалён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Такого задолжника не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                    break;
                case "Vogue":
                    fam = textBox1.Text;
                    SqlDataAdapter adap = new SqlDataAdapter();
                    DataTable Tablee = new DataTable();
                    string queree = $"select * from SovBanck";
                    SqlCommand cmde = new SqlCommand(queree, con);
                    adap.SelectCommand = cmde;
                    adap.Fill(Tablee);
                    con.Open();
                    SqlCommand insertCommande = new SqlCommand($"DELETE FROM Vogue WHERE Паспортные_данные = '{textBox1.Text}'", con);
                    if (insertCommande.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Задолжник успешно удалён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Такого задолжника не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                    break;
                case "Rosselkhoz":
                    fam = textBox1.Text;
                    SqlDataAdapter adape = new SqlDataAdapter();
                    DataTable Tabla = new DataTable();
                    string quera = $"select * from SovBanck";
                    SqlCommand cmda = new SqlCommand(quera, con);
                    adape.SelectCommand = cmda;
                    adape.Fill(Tabla);
                    con.Open();
                    SqlCommand insertCommanda = new SqlCommand($"DELETE FROM Rosselkhoz WHERE Паспортные_данные = '{textBox1.Text}'", con);
                    if (insertCommanda.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Задолжник успешно удалён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Такого задолжника не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ydal();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                h(dataGridView1);
                comboBox1.Text = tabPage1.Text;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                k(dataGridView2);
                comboBox1.Text = tabPage2.Text;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                d(dataGridView3);
                comboBox1.Text = tabPage3.Text;
            }
            if (tabControl1.SelectedIndex == 3)
            {
                m(dataGridView4);
                comboBox1.Text = tabPage4.Text;
            }
            if (tabControl1.SelectedIndex == 4)
            {
                j(dataGridView5);
                comboBox1.Text = tabPage5.Text;
            }
        }

        public void refrech()
        {
            this.Close();
            Таблицы таб = new Таблицы();
            таб.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            refrech();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrows;
            selectedrows = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedrows];

                if (row.Cells[0].Value == null)
                {
                    MessageBox.Show("Выбрано пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Text = row.Cells[4].Value.ToString();
                }

            }
        }

        private void dataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrows;
            selectedrows = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedrows];

                if (row.Cells[0].Value == null)
                {
                    MessageBox.Show("Выбрано пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Text = row.Cells[4].Value.ToString();
                }

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrows;
            selectedrows = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedrows];

                if (row.Cells[0].Value == null)
                {
                    MessageBox.Show("Выбрано пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Text = row.Cells[4].Value.ToString();
                }

            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrows;
            selectedrows = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedrows];

                if (row.Cells[0].Value == null)
                {
                    MessageBox.Show("Выбрано пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Text = row.Cells[4].Value.ToString();
                }

            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrows;
            selectedrows = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView5.Rows[selectedrows];

                if (row.Cells[0].Value == null)
                {
                    MessageBox.Show("Выбрано пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Text = row.Cells[4].Value.ToString();
                }

            }
        }
    }
    }

