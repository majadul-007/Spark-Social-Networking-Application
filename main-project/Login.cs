using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace project
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification f2 = new Notification();
            f2.Show();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f4 = new SignUp();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from register_details where username = @user and pass = @pass";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox5.Text);
            cmd.Parameters.AddWithValue("@pass", textBox3.Text);
            //cmd.Parameters.AddWithValue("@confpass", textBox3.Text);
            con.Open();
            /*int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                this.Hide();
                Spark f2 = new Spark();
                f2.Show();
            }
            else
            {
                MessageBox.Show("No Account Found! Register a new account!");
            }*/
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {

                this.Hide();
                Spark f2 = new Spark();
                f2.Show();
                //MessageBox.Show("login successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("login failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp s1 = new SignUp();
            s1.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    textBox3.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox3.UseSystemPasswordChar = true;
                    break;
            }
        }
    }
}
