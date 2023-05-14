using System.Data.SqlClient;

namespace LoginRegistration
{
    public partial class Login : Form
    {
        private string connectionString = @"Data Source = SAHIB-LAPTOP; Integrated Security = SSPI; Initial Catalog = UserDB;";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль");
                return;
            }


            bool isValidUser = ValidateUser(textBox1.Text, textBox2.Text);


            if (isValidUser)
            {

                MessageBox.Show("Успешный вход!");
            }

            else
            {

                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private bool ValidateUser(string username, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", connection);


                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {

                    connection.Open();


                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message);
                    return false;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registerForm = new Registration(connectionString);
            registerForm.Show();
        }
    }
}