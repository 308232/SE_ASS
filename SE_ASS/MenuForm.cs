﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_ASS
{
    

    public partial class MenuForm : Form
    {
       public string userRights;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnSubmitUserNamePassword_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "Owner") &&(txtPassword.Text=="asdf"))
            {
                userRights = "Owner";

                MainForm MainForm = new MainForm();
                MainForm.btnAllCAss.Visible = false;
                MainForm.label4.Visible = false;
                MainForm.label5.Visible = false;
                MainForm.label6.Visible = false;
                MainForm.txtboxCourierID.Visible = false;
                MainForm.txtboxCourierdate.Visible = false;
                MainForm.lblTitle.Text = "WELCOME OWNER";



                this.Hide();
               MainForm.Show();

            }
            else if ((txtUserName.Text == "Admin") && (txtPassword.Text == "asd"))
            {
                userRights = "Admin";

                MainForm MainForm = new MainForm();
                
                this.Hide();
                MainForm.Show();
            }
            else if ((txtUserName.Text == "LC") && (txtPassword.Text == "as"))
            {
                userRights = "LC";

               MainForm MainForm = new MainForm();
                this.Hide();
                MainForm.Show();
                MainForm.lblTitle.Text = "WELCOME LC";
                MainForm.button1.Visible = false;
            }
            else if ((txtUserName.Text == "Couriers") && (txtPassword.Text == "a"))
            {
                userRights = "Couriers";

                CourrierForm CourrierForm = new CourrierForm();
                this.Hide();
               CourrierForm.Show();
            }
            else
            {
                MessageBox.Show("You Have entered incorect username or password. Please try again");
                txtUserName.Clear();
                txtPassword.Clear();
            }





        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
