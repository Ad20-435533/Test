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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();

            Random random_num = new Random();
            int num = random_num.Next(1000, 9999);
            captcha.Text = num.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string login_text = login.Text;
            string password_text = password.Text;
            string captcha_out = captcha.Text;
            string captcha_in = captcha_text.Text;

            const string conn = "Data Source=localhost; Initial Catalog=ps-base; Integrated Security=True";
            SqlConnection myConn = new SqlConnection(conn);
            myConn.Open();

            const string sqlsellect = "SELECT * FROM [user] WHERE login = @login AND pasword = @password";
            SqlCommand command = new SqlCommand(sqlsellect, myConn);
            command.Parameters.AddWithValue("@login", login_text);
            command.Parameters.AddWithValue("@password", password_text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0 && captcha_in == captcha_out)
            {
                MessageBox.Show("LP Done");
            }
            else
            {
                Random random_num = new Random();
                int num = random_num.Next(1000, 9999);
                captcha.Text = num.ToString();

                captcha_text.Clear();
                password.Clear();
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random random_num = new Random();
            int num = random_num.Next(1000, 9999);
            captcha.Text = num.ToString();
        }
    }
}
