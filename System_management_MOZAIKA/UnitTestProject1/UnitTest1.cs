using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string connect = "Data Source=DESKTOP-T20O278;Initial Catalog=\"Казенов Эдуард Практика\";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        [TestMethod]
        public void TestMethod1()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string username = "Gen";
                string query = "SELECT ID_Кадра FROM ВХОД WHERE ЛОГИН = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        string role = reader["ID_Кадра"].ToString();
                        Assert.AreEqual("1", role);
                    }
                }
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string role = "Администратор";
                string query = "SELECT Наименование_доступа FROM ДОСТУП WHERE Наименование_доступа = @role";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@role", role);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        role = reader["Наименование_доступа"].ToString();
                        Assert.AreEqual("Администратор", role);
                    }
                }
            }
        }


        [TestMethod]
        public void TestMethod3()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string health_status = "Здоров";
                string query = "SELECT Состояние_здоровья FROM СОТРУДНИКИ WHERE Состояние_здоровья = @health_status";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@health_status", health_status);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        string health = reader["Состояние_здоровья"].ToString();
                        Assert.AreEqual("Здоров", health);
                    }
                }
            }
        }
    }
}
