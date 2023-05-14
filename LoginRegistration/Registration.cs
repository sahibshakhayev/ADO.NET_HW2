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

namespace LoginRegistration
{

    public partial class Registration : Form
    {
        private string connectionString = null;
        public Registration(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }











        private void AddUser(string firstName, string lastName, string username, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("INSERT INTO Users (FirstName, LastName, Username, Password) VALUES (@FirstName, @LastName, @Username, @Password)", connection);


                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {

                    connection.Open();


                    command.ExecuteNonQuery();


                    MessageBox.Show("Вы успешно зарегистрировались");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox4.Text == "" || textBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            
            if (textBox2.Text != textBox5.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            
            AddUser(textBox4.Text, textBox3.Text, textBox1.Text, textBox2.Text);

           
            this.Close();
        }
    }
}
