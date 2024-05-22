using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кантора1
{
    public partial class Status : Form
    {
        static string serverName = @"DESKTOP-2F416IT";
        static string dbName = "Должен";

        SqlConnection con = new SqlConnection($@"Data Source={serverName};Initial Catalog={dbName};Integrated Security=True");
        public Status(string username)
        {
            
            InitializeComponent();
            
            c();
            label1.Text = username;

        }
        
        private void c()
        {
            dataGridView1.Columns.Add("Сумма_задолжности", "Сумма задолжности");
            dataGridView1.Columns.Add("Статус_долга", "Статус долга");
        }
        private void p(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1));
        }
        private void d(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select Сумма_задолжности, Статус_долга from [{comboBox1.Text}] where Логин = '{label1.Text}'";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                d(dataGridView1);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                d(dataGridView1);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                d(dataGridView1);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                d(dataGridView1);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                d(dataGridView1);
            }

        }

        private void Status_Load(object sender, EventArgs e)
        {

        }
    }
}
