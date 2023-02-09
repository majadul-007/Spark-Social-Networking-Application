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
    public partial class Covid_19 : Form
    {
        public Covid_19()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            News n1 = new News();
            n1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Explore e1 = new Explore();
            e1.Show();
        }
    }
}
