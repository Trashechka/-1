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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Кантора1
{
    public partial class Заявка : Form
    {
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\logs" + @"\logs.txt";
        string admin = "";
        private int userId;
        string fam = "";
        string immortal = "";
        string otchim = "";
        string nom;
        string pass;
        string adress = "";
        decimal stoim;
        static string serverName = @"DESKTOP-2F416IT";
        static string dbName = "Должен";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public Заявка(string username)
        {
            InitializeComponent();
            textBox6.TextChanged += textBox6_TextChanged;
            textBox2.Text = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        public void zayavka()
        {
            string a = comboBox1.SelectedItem.ToString();
            switch (a)
            {
                case "SovBanck":
                    fam = textBox1.Text;
                    immortal = textBox5.Text;
                    otchim = textBox4.Text;
                    nom = maskedTextBox1.Text;
                    pass = maskedTextBox2.Text;
                    adress = textBox7.Text;
                    stoim = Convert.ToDecimal(textBox6.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable Table = new DataTable();
                    string quere = $"select * from SovBanck";
                    SqlCommand cmd = new SqlCommand(quere, con);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(Table);
                    con.Open();
                    SqlCommand insertCommand = new SqlCommand($"insert into SovBanck(Фамилия, Имя, Отчество, Номер_телефона, Паспортные_данные, Адрес_прописки, Сумма_задолжности, Логин ) values ('{fam}','{immortal}','{otchim}','{nom}','{pass}','{adress}','{stoim}','{textBox2.Text}')", con);
                    if (insertCommand.ExecuteNonQuery() == 1)
                    {
                        if (fam == "" || immortal == "" || otchim == "" || nom == "" || adress == "")
                        {
                            MessageBox.Show("Пожалуйста, введите все данные задолжника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        if (stoim < 0 || stoim == 0)
                        {
                            MessageBox.Show("Задолжность не может быть меньше или равна 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        MessageBox.Show("Задолжник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    con.Close();
                    break;
                case "My Bank":

                    fam = textBox1.Text;
                    immortal = textBox5.Text;
                    otchim = textBox4.Text;
                    nom = maskedTextBox1.Text;
                    pass = maskedTextBox2.Text;
                    adress = textBox7.Text;
                    stoim = Convert.ToDecimal(textBox6.Text);
                    SqlDataAdapter adapte = new SqlDataAdapter();
                    DataTable Tabl = new DataTable();
                    string quee = $"select * from My_Bank";
                    SqlCommand cm = new SqlCommand(quee, con);
                    adapte.SelectCommand = cm;
                    adapte.Fill(Tabl);
                    con.Open();
                    SqlCommand insertComman = new SqlCommand($"insert into My_Bank(Фамилия, Имя, Отчество, Номер_телефона, Паспортные_данные, Адрес_прописки, Сумма_задолжности, Логин ) values ('{fam}','{immortal}','{otchim}','{nom}','{pass}','{adress}','{stoim}','{textBox2.Text}')", con);
                    if (insertComman.ExecuteNonQuery() == 1)
                    {
                        if (fam == "" || immortal == "" || otchim == "" || nom == "" || adress == "")
                        {
                            MessageBox.Show("Пожалуйста, введите все данные задолжника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        if (stoim < 0 || stoim == 0)
                        {
                            MessageBox.Show("Задолжность не может быть меньше или равна 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        MessageBox.Show("Задолжник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    con.Close();
                    break;
                case "TirSbanck":

                    fam = textBox1.Text;
                    immortal = textBox5.Text;
                    otchim = textBox4.Text;
                    nom = maskedTextBox1.Text;
                    pass = maskedTextBox2.Text;
                    adress = textBox7.Text;
                    stoim = Convert.ToDecimal(textBox6.Text);
                    SqlDataAdapter adapt = new SqlDataAdapter();
                    DataTable Tab = new DataTable();
                    string que = $"select * from TirSbanck";
                    SqlCommand cms = new SqlCommand(que, con);
                    adapt.SelectCommand = cms;
                    adapt.Fill(Tab);
                    con.Open();
                    SqlCommand insertComma = new SqlCommand($"insert into TirSbanck(Фамилия, Имя, Отчество, Номер_телефона, Паспортные_данные, Адрес_прописки, Сумма_задолжности, Логин ) values ('{fam}','{immortal}','{otchim}','{nom}','{pass}','{adress}','{stoim}','{textBox2.Text}')", con);
                    if (insertComma.ExecuteNonQuery() == 1)
                    {
                        if (fam == "" || immortal == "" || otchim == "" || nom == "" || adress == "")
                        {
                            MessageBox.Show("Пожалуйста, введите все данные задолжника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        if (stoim < 0 || stoim == 0)
                        {
                            MessageBox.Show("Задолжность не может быть меньше или равна 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        MessageBox.Show("Задолжник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    con.Close();
                    break;
                case "Vogue":

                    fam = textBox1.Text;
                    immortal = textBox5.Text;
                    otchim = textBox4.Text;
                    nom = maskedTextBox1.Text;
                    pass = maskedTextBox2.Text;
                    adress = textBox7.Text;
                    stoim = Convert.ToDecimal(textBox6.Text);
                    SqlDataAdapter adap = new SqlDataAdapter();
                    DataTable Tabak = new DataTable();
                    string queq = $"select * from Vogue";
                    SqlCommand cmq = new SqlCommand(queq, con);
                    adap.SelectCommand = cmq;
                    adap.Fill(Tabak);
                    con.Open();
                    SqlCommand insertComm = new SqlCommand($"insert into Vogue(Фамилия, Имя, Отчество, Номер_телефона, Паспортные_данные, Адрес_прописки, Сумма_задолжности, Логин ) values ('{fam}','{immortal}','{otchim}','{nom}','{pass}','{adress}','{stoim}','{textBox2.Text}')", con);
                    if (insertComm.ExecuteNonQuery() == 1)
                    {
                        if (fam == "" || immortal == "" || otchim == "" || nom == "" || adress == "")
                        {
                            MessageBox.Show("Пожалуйста, введите все данные задолжника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        if (stoim < 0 || stoim == 0)
                        {
                            MessageBox.Show("Задолжность не может быть меньше или равна 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        MessageBox.Show("Задолжник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    con.Close();
                    break;
                case "Rosselkhoz":

                    fam = textBox1.Text;
                    immortal = textBox5.Text;
                    otchim = textBox4.Text;
                    nom = maskedTextBox1.Text;
                    pass = maskedTextBox2.Text;
                    adress = textBox7.Text;
                    stoim = Convert.ToDecimal(textBox6.Text);
                    SqlDataAdapter ada = new SqlDataAdapter();
                    DataTable Tablica = new DataTable();
                    string qu = $"select * from Rosselkhoz";
                    SqlCommand cmm = new SqlCommand(qu, con);
                    ada.SelectCommand = cmm;
                    ada.Fill(Tablica);
                    con.Open();
                    SqlCommand insertCom = new SqlCommand($"insert into Rosselkhoz(Фамилия, Имя, Отчество, Номер_телефона, Паспортные_данные, Адрес_прописки, Сумма_задолжности, Логин ) values ('{fam}','{immortal}','{otchim}','{nom}','{pass}','{adress}','{stoim}','{textBox2.Text}')", con);
                    if (insertCom.ExecuteNonQuery() == 1)
                    {
                        if (fam == "" || immortal == "" || otchim == "" || nom == "" || adress == "")
                        {
                            MessageBox.Show("Пожалуйста, введите все данные задолжника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        if (stoim < 0 || stoim == 0)
                        {
                            MessageBox.Show("Задолжность не может быть меньше или равна 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            return;
                        }
                        MessageBox.Show("Задолжник успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    con.Close();
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            zayavka();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            Status stat = new Status(username);
            stat.ShowDialog();
        }

        private void Заявка_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "0";
            }
        }

        private void Заявка_Load(object sender, EventArgs e)
        {

        }
    }
}
    

