using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cross_Alpha
{
    public partial class Home : Form
    {
        private String help_message = "";
        public Home()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            Register l_form = new Register();
            l_form.Show();
            this.Hide();
        }

        private void Race_button_Click(object sender, EventArgs e)
        {
            Race l_form = new Race();
            l_form.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(help_message);
        }
    }
}