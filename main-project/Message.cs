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
    public partial class Message : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Message()
        {
            InitializeComponent();
            allMethods();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Spark s2= new Spark();
            s2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Explore e1 = new Explore();
            e1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p1 = new Profile();
            p1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox4.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackColor = Color.Transparent;


        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.Transparent;


        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.Transparent;

        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox8.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox8.BackColor = Color.Transparent;

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.BackColor = Color.Transparent;

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "Start a new message..")
            {
                textBox2.Text = "";
                
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "Start a new message..";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
                 if (textBox1.Text == "Search Here..")
            {
                textBox1.Text = "";

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search Here..";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        void allMessages()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from message_details where  username='John Doe' ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //label16= " ";
                        label8.Text = (reader["text"].ToString());
                        //label17.Text = (reader["detail"].ToString());
                        /*label18.Text = (reader["header"].;
                        label18.Text = (reader["header"].ToString());
                        label19.Text = (reader["detail"].ToString());*/

                    }
                }
            }
            finally
            {
                con.Close();
            }



        }

        void allMethods()
        {
            label13.Hide();
            allMessages();
          //  pictureBox15_Click();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label13.Show();
            //var i = 0;

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into user_message values (@message)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@message", textBox2.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {

                dataGridView1();
                textBox2.Text = "";
                /*if (i == 0)
                {

                dataGridView1();
                textBox2.Text = "";
                    
                }
                else
                {
                dataGridView2();
                textBox2.Text = "";

                }*/
                //textBox1.Text = "";

                // MessageBox.Show("data inserted successfully");

            }
            else
            {
                MessageBox.Show("You must type Something to give a status");
            }
            
        }
        void dataGridView1()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from user_message";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
           
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //int i = 0;
                       
                            label13.Text = "";
                            label13.Text = (reader["text"].ToString());
                            

                    }
                }
            }
            finally
            {
                con.Close();
            }





        }

       /* void dataGridView2()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from user_message";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //int i = 0;
                        label14.Text = "";
                        label14.Text = (reader["text"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }





        }*/

        private void label13_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
