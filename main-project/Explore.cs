using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Explore : Form
    {
        public Explore()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Message m1 = new Message();
            m1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
            //if(pictureBox6.BackColor == )
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Covid_19 c1 = new Covid_19();
            c1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            News n1 = new News();
            n1.Show();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            /*this.Hide();
            Spark s1 = new Spark();
            s1.Show();*/
            this.Hide();
            Spark s1 = new Spark();
            s1.Show();
            
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Message m1 = new Message();
            m1.Show();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.Show();


        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Profile p1 = new Profile();
            p1.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox4.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.Transparent;
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

        private void Explore_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
