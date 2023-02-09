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
    public partial class SignUp : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString; 
       public SignUp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into register_details values (@user, @pass, @confpass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox4.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            cmd.Parameters.AddWithValue("@confpass", textBox2.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Account Created Successfully!");
            }
            else
            {
                MessageBox.Show("Account Creation Failed! Try Again");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    textBox1.UseSystemPasswordChar = false;
                    textBox2.UseSystemPasswordChar = false;
                    
                    break;
                default:
                    textBox1.UseSystemPasswordChar = true;
                    textBox2.UseSystemPasswordChar = true;

                    break;
            }
        }
    }
}
