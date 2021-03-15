using System;
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

        public void btnSubmitUserNamePassword_Click(object sender, EventArgs e)
        {
            //if statemnet in order to check Username and password 
            if ((txtUserName.Text == "Owner") &&(txtPassword.Text=="asdf"))
            {
                userRights = "Owner";

                //Assignnng different rights to different people depending on the username and password. Hiding and showing buttons and then loading the Mainform if Owner is logged in
                //hiding, showing the correct buttons and changing the titile label to match the correct user 
                MainForm MainForm = new MainForm();
                MainForm.btnAllCAss.Visible = false;
                MainForm.label4.Visible = false;
                MainForm.label5.Visible = false;
                MainForm.label6.Visible = false;
                MainForm.txtboxCourierID.Visible = false;
                MainForm.txtboxCourierdate.Visible = false;
                MainForm.lblTitle.Text = "WELCOME OWNER";
                MainForm.button2.Visible = false;


                this.Hide();
               MainForm.Show();

            }
            else if ((txtUserName.Text == "Admin") && (txtPassword.Text == "asd"))
            {
                //Assignnng different rights to different people depending on the username and password. Hiding and showing buttons and then loading the Mainform if Admin is logged in
                userRights = "Admin";

                MainForm MainForm = new MainForm();
                
                this.Hide();
                MainForm.Show();
            }
            else if ((txtUserName.Text == "LC") && (txtPassword.Text == "as"))
            {
                userRights = "LC";

                //Assignnng different rights to different people depending on the username and password. Hiding and showing buttons and then loading the Mainform if LC is logged in

                MainForm MainForm = new MainForm();
                this.Hide();
                MainForm.Show();
                //hiding, showing the correct buttons and changing the titile label to match the correct user 
                MainForm.lblTitle.Text = "WELCOME LC";
                MainForm.button1.Visible = false;
            }
            else if ((txtUserName.Text == "a") && (txtPassword.Text == "a"))
            {
                //Assignnng different rights to different people depending on the username and password. Hiding and showing buttons and then loading the Mainform if Courier is logged in
                userRights = "Couriers";
                MainForm MainForm = new MainForm();
                this.Hide();

                //hiding, showing the correct buttons and changing the titile label to match the correct user 
                MainForm.Show();
                MainForm.lblTitle.Text = "WELCOME COURIER";
                MainForm.button1.Visible = false;
                MainForm.label1.Visible = false;
                MainForm.btnCreateNewClientContract.Visible = false;
                MainForm.btnAllCAss.Visible = true;
                MainForm.label2.Visible = false;
                MainForm.label3.Visible = false;
                MainForm.txtboxStartDate.Visible = false;
                MainForm.txtboxEndDate.Visible = false;
                MainForm.button1.Visible = false;
                MainForm.btnShowAllAssForACourierForADAY.Visible = false;
                MainForm.button2.Visible = false;
                MainForm.btnCourierAss.Visible = true;

            }
            else
            {
                //message if wron username and password is entered 
                MessageBox.Show("You Have entered incorect username or password. Please try again");
                txtUserName.Clear();
                txtPassword.Clear();
            }





        }

        public void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
