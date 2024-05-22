using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кантора1
{
    public partial class Form1 : Form


    {
        public string admin = "";
        public string login = "";
        public string pass = "";
        static string serverName = @"DESKTOP-2F416IT";
        static string dbName = "Должен";

        SqlConnection con = new SqlConnection($@"Data Source={serverName};Initial Catalog={dbName};Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            pass = textBox2.Text;

            if (login == "" || pass == "")
            {
                MessageBox.Show("Пожалуйста, введите логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            logins();
        }

        private void logins()
        {
            //подключение к бд
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();

            string quere = $"select Логин, Пароль from Вход where Логин='{login}' and Пароль='{pass}'";
            SqlCommand command = new SqlCommand(quere, con);
            adapter.SelectCommand = command;
            adapter.Fill(Table);
            //условие входа( если данные из бд совпадают с данным введенными в textbox, вход успешен)
            if (Table.Rows.Count == 1)
            {

                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //если в поля авторизации были введены данные admin, происходит вход в аккаунт админа
                if (login == "admin")
                {
                    Таблицы admin = new Таблицы();
                    admin.Show();
                }
                else;

                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                this.Hide();
                con.Close();

            }             //если данные аккаунта не совпадают с существующими данными в бд,вход не будет совершен
            else
            {
                MessageBox.Show("Неверный логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Гашение form1 = new Гашение();
            form1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            auth auth = new auth();
            auth.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}

