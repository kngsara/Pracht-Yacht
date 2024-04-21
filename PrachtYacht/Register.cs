using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrachtYacht
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
        }
    }
}
