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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.Transparent;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "ALL Files *.jpg* |*.png*";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox9.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Title = "Select Image";
            ofd2.Filter = "ALL Files *.jpg* |*.png*";
            //ofd.ShowDialog();
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                pictureBox14.Image = new Bitmap(ofd2.FileName);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
