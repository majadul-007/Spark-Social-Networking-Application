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
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Explore f3 = new Explore();
            f3.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Spark s1 = new Spark();
            s1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Message m1 = new Message();
            m1.Show();

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

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
