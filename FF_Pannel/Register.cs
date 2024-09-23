using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FF_Pannel
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1.KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (Form1.KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
               Status.Text ="Status: " + Form1.KeyAuthApp.response.message;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Form1.KeyAuthApp.init();
        }
    }
}
