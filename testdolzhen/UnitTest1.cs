using Microsoft.VisualStudio.TestTools.UnitTesting;
using Кантора1;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testdolzhen
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testfroms()
        {
            Form f = new Form();
            f.Show();
            Assert.IsTrue(f.Visible);
        }
        private string connectionString = "Data Source=DESKTOP-2F416IT; Initial Catalog=Должен;Integrated Security = True";
        [TestMethod]
        public void Testdatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Assert.AreEqual(ConnectionState.Open, connection.State);
                }
                catch (SqlException ex)
                {
                    Assert.Fail($"Ошибка: {ex.Message}");
                }
            }
        }
        [TestMethod]
        public void Testgridview()
        {
            Таблицы таб = new Таблицы();
            таб.f();
            таб.g();
            таб.a();
            таб.b();
            таб.c();
        }
        [TestMethod]
        public void Testrefrech()
        {
            Таблицы таб = new Таблицы();
            таб.refrech();
        }
    }
}
