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

        private void btnSubmitUserNamePassword_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "Owner") &&(txtPassword.Text=="asdf"))
            {
                userRights = "Owner";

                MainForm MainForm = new MainForm();
                
                this.Hide();
                MainForm.Show();
            
            }
            else if ((txtUserName.Text == "Admin") && (txtPassword.Text == "asd"))
            {
                userRights = "Admin";

                AdminForm AdminForm = new AdminForm();
                this.Hide();
                AdminForm.Show();
            }
            else if ((txtUserName.Text == "LC") && (txtPassword.Text == "as"))
            {
                userRights = "LC";

               LcForm LcForm = new LcForm();
                this.Hide();
                LcForm.Show();
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
