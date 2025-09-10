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

namespace System_management_MOZAIKA
{
    public partial class MainForm : Form
    {
        private readonly string connect = "Data Source=DESKTOP-T20O278;Initial Catalog=\"Казенов Эдуард Практика\";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = logintextBox.Text.Trim();
            string password = passwordtextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();

                    string query = "SELECT ID_Кадра, ПАРОЛЬ FROM ВХОД WHERE ЛОГИН = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["ПАРОЛЬ"].ToString();
                                string role = reader["ID_Кадра"].ToString();

                                if (dbPassword == password)
                                {
                                    OpenFormByRole(role);
                                }
                                else
                                {
                                    MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenFormByRole(string role)
        {
            Form formToOpen = null;

            switch (role)
            {
                case "1":
                    formToOpen = new Form1();
                    break;
                case "2":
                    formToOpen = new Form2();
                    break;
                case "3":
                    formToOpen = new Form3();
                    break;
                case "4":
                    formToOpen = new Form4();
                    break;
                case "5":
                    formToOpen = new Form5();
                    break;
                default:
                    MessageBox.Show("Неизвестная роль пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            this.Hide();
            formToOpen.Closed += (s, args) => this.Close();
            formToOpen.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logintextBox.Focus();
        }
        private void passwordtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
