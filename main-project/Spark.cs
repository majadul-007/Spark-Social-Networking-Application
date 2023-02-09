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
//using System.Threading.Tasks; 
//static System.Timers.Timer;
using System.Timers;

namespace project
{
    public partial class Spark : Form
    {
        /*int s = 2;

        int counter = 1; //minutes counter*/

        //System.Timers.Timer aTimer;
        //private static System.Timers.Timer aTimer;

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Spark()
        {
            InitializeComponent();
            //dataGridView();
            callAllFunctions();
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Explore e1 = new Explore();
            //e1.BackColor = Color.Red;
            //e1. = Color.Red;
            e1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Message m1 = new Message();
            m1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p1 = new Profile();
            p1.Show();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void Spark_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into status_details values (@status)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                dataGridView();
                textBox1.Text = "";

                // MessageBox.Show("data inserted successfully");

            }
            else
            {
                MessageBox.Show("You must type Something to give a status");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        void dataGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from status_details";
            
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //DataTable data = new DataTable();

            //cmd.fill;
            //dataGridView1.DataSource = data;

            /* if (reader.HasRows)
             {

                     int n = 1;

                         label11.Text = "";
                          reader.Read();
                 //String  id = Convert.ToInt32(reader[0]);
                 label11.Text = reader.GetValue(3).ToString();       
                 //label11.Text = reader.Tables[0].Rows[n]["userstatus"].ToString();

                     // Label4.Text += login.Tables[0].Rows[1]["Password"].ToString() + "<br />";
                     //n++;
                 }*/
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        label11.Text = "";
                        label11.Text = (reader["userstatus"].ToString());
                        
                    }
                }
            }
            finally
            {
                con.Close();
            }





        }


        void latestTrends()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from latest_trends where  header='Washington News' ";

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
                        label16.Text = (reader["header"].ToString());
                        label17.Text = (reader["detail"].ToString());
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

        void latestTrends2()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from latest_trends where  header='BBC News' ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        label18.Text = (reader["header"].ToString());
                        label19.Text = (reader["detail"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }



        }
        void latestTrends3()
        {
           
            //await Task.Delay(TimeSpan.FromSeconds(10));
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from latest_trends where  header='birthday' ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //label18.Text = (reader["header"].ToString());
                        label20.Text = (reader["detail"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }



        }

        void latestTrends4()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from latest_trends where  header='request' ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //label18.Text = (reader["header"].ToString());
                        label21.Text = (reader["detail"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }



        }

        void userStatus1()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from all_status where  username='Tusher @banik32' ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //label18.Text = (reader["header"].ToString());
                        label12.Text = (reader["userstatus"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }



        }

        void userStatus2()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from all_status where  username='Asif @asif373' ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                //con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //label18.Text = (reader["header"].ToString());
                        label14.Text = (reader["userstatus"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }



        }
        void callAllFunctions()
        {
            latestTrends();
            latestTrends2();
            latestTrends3();
            //checkTiming();
           // foo();
            latestTrends4();
            userStatus1();
            userStatus2();

        }

        public void foo()
        {
            Task.Delay(1000).ContinueWith(t => latestTrends3());
        }


        /*internal static void Run()
       {
           int seconds = 5 * 1000;

           var timer =
               new Timer(TimerMethod, seconds);

           Console.ReadKey();
       }

       private static void TimerMethod(object o)
       {
           Console.WriteLine(
               "Running: " + DateTime.Now);
       }*/
        /*static async void DoSomethingLater(int n)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            //DoSomething(n);
        }*/

        void checkTiming()
        {
            Task.Delay(new TimeSpan(0, 0, 5)).ContinueWith(o => { latestTrends3(); });

        }

       




        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
       /* private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            //this.pictureBox6.BackColor = Color.SeaShell;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox8.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox8.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.Transparent;
        }*/

        private void pictureBox6_MouseHover_1(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.Transparent;
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
