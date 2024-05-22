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
    public partial class auth : Form
    {
        public string admin = "";
        public string UserLogin = "";
        public string UserPass = "";
        static string serverName = @"DESKTOP-2F416IT";
        static string dbName = "Должен";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public auth()
        {
            InitializeComponent();
        }
        private void login()
        {
            string username = textBox1.Text;
            //подключение к бд
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();

            string quere = $"select Логин, Пароль from Вход where Логин='{UserLogin}' and Пароль='{UserPass}'";
            SqlCommand command = new SqlCommand(quere, con);
            adapter.SelectCommand = command;
            adapter.Fill(Table);
            //условие входа( если данные из бд совпадают с данным введенными в textbox, вход успешен)
            if (Table.Rows.Count == 1)
            {

                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Hide();
                
                Заявка заявка = new Заявка(username);
                заявка.ShowDialog();


                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                con.Close();

            }
            //если данные аккаунта не совпадают с существующими данными в бд,вход не будет совершен
            else
            {
                MessageBox.Show("Неверный логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin = textBox1.Text;
            UserPass = textBox2.Text;
            if (UserLogin == "" || UserPass == "")
            {
                MessageBox.Show("Пожалуйста, введите логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            login();
            /*
            string username = "";
            this.Hide();
            Заявка form1 = new Заявка(username);
            form1.ShowDialog();*/
            
        }

        private void auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void auth_Load(object sender, EventArgs e)
        {

        }
    }
}
