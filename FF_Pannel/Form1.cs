using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;

namespace FF_Pannel
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
    name: "FF_Pannel", // Application Name
    ownerid: "BGjNiJR8r0", // Owner ID
    secret: "53c406f0913f5416a7e7b8cb28ae18cceb33107d6b710df08caede667dd0d139", // Application Secret
    version: "1.0" // Application Version /*
                   //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
);
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                Status.Text = "Status: " + KeyAuthApp.response.message;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Status_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register main = new Register();
            main.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
