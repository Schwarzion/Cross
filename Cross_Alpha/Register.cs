using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Cross_Alpha
{
    public partial class Register : Form
    {
        private Tools function;
        private string name, firstname, classe, RFID;

        public Register()
        {
            InitializeComponent();
            function = new Tools();
        }

        private void name_combobox_DropDown(object sender, EventArgs e)
        {
            ArrayList Name_List = new ArrayList();
            ArrayList Firstname_List = new ArrayList();
            name = name_combobox.Text;
            Name_List = function.Read_Name(name);
            Firstname_List = function.Read_Firstname(name);
            this.name_combobox.Items.Clear();
            for (int i = 0; i < Name_List.Count; i++)
                this.name_combobox.Items.Add(Name_List[i] + " " + Firstname_List[i]);

        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_RFID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }     
        }

        private void name_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = name_combobox.SelectedItem.ToString();
            firstname = name_combobox.SelectedItem.ToString();
            name = name.Split()[0];
            firstname = firstname.Remove(0, firstname.IndexOf(' ') + 1);
            string[] donnees = function.Read_Data(name, firstname);
            this.label_Name.Text = "" + name;
            this.label_Firstname.Text = "" + firstname;
            this.label_Class.Text = "" + donnees[0];
        }

        private void textBox_RFID_TextChanged(object sender, EventArgs e)
        {
            button_register.Visible = true;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            RFID = textBox_RFID.Text;
            name = label_Name.Text;
            firstname = label_Firstname.Text;
            classe = label_Class.Text;
            function.Add_RFID(RFID, name, firstname, classe);
            MessageBox.Show("Enregistrement effectué");
            textBox_RFID.Text = "";
            label_Name.Text = "";
            label_Firstname.Text = "";
            label_Class.Text = "";
            name_combobox.Text = "";
        }
    }
}