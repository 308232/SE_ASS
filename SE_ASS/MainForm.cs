using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace SE_ASS
{
    public partial class MainForm : Form
    {
        System.Data.SqlClient.SqlConnection newCon;
        DataSet dsCustomer;
        System.Data.SqlClient.SqlDataAdapter daCustomer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewClientContract_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "WELCOME OWNER")
            {
                NewClientForm NewClientForm = new NewClientForm();
                NewClientForm.btnBackLC.Visible = false;
                NewClientForm.btnBack.Visible = false;
                NewClientForm.btnAddNewClient.Visible = false;
                NewClientForm.btnSaveNewClientRecord.Visible = false;
                NewClientForm.btnEDIT.Visible = false;
                NewClientForm.btnUPDATE.Visible = false;

                this.Hide();
                NewClientForm.Show();
            }
            else if(lblTitle.Text=="WELCOME ADMIN")
            {
                NewClientForm NewClientForm = new NewClientForm();
                NewClientForm.btnBackLC.Visible = false;
                NewClientForm.btnBackOwner.Visible = false;
                NewClientForm.btnAddNewClient.Visible = true;
                NewClientForm.btnSaveNewClientRecord.Visible = true;
                NewClientForm.btnEDIT.Visible = true;
                NewClientForm.btnUPDATE.Visible = false;

                this.Hide();
                NewClientForm.Show();
            }
            else if (lblTitle.Text == "WELCOME LC")
            {
                NewClientForm NewClientForm = new NewClientForm();
                NewClientForm.btnBack.Visible = false;
                NewClientForm.btnBackLC.Visible = true;
                NewClientForm.btnBackOwner.Visible = false;
                NewClientForm.btnAddNewClient.Visible = false;
                NewClientForm.btnSaveNewClientRecord.Visible = false;
                NewClientForm.btnEDIT.Visible = true;
                NewClientForm.btnUPDATE.Visible = false;
              
                this.Hide();
                NewClientForm.Show();
            }
        }

        private void btnShowAllAssForACourierForADAY_Click(object sender, EventArgs e)
        {
           
            
            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            //sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart ='2021-03-10'";
            sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart BETWEEN '"+txtboxStartDate.Text+"' AND '"+txtboxEndDate.Text+"'";
            

            try
            {
                //open the database connection 
                newCon.Open();
                //setting the data adapter and filling it with the information 
                daCustomer = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, newCon);
                daCustomer.Fill(dsCustomer, "Customers");
                dataGridViewAdmin.DataSource = dsCustomer.Tables[0];





            }
            catch
            {
                MessageBox.Show("Yess");

            }
            newCon.Close();
        }

        private void btnAllCAss_Click(object sender, EventArgs e)
        {
            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            //sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart ='2021-03-10'";
            //sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE CourierID= '"+txtboxCourierID.Text+"'";
            sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart = '" + txtboxCourierdate.Text + "' AND CourierID='"+txtboxCourierID.Text+"'";


            try
            {
                //open the database connection 
                newCon.Open();
                //setting the data adapter and filling it with the information 
                daCustomer = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, newCon);
                daCustomer.Fill(dsCustomer, "Customers");
                dataGridViewAdmin.DataSource = dsCustomer.Tables[0];





            }
            catch
            {
                MessageBox.Show("Yess");

            }
            newCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            //sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart ='2021-03-10'";
            sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart BETWEEN '" + txtboxStartDate.Text + "' AND '" + txtboxEndDate.Text + "'";


            try
            {
                //open the database connection 
                newCon.Open();
                //setting the data adapter and filling it with the information 
                daCustomer = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, newCon);
                daCustomer.Fill(dsCustomer, "Customers");
                dataGridViewAdmin.DataSource = dsCustomer.Tables[0];





            }
            catch
            {
                MessageBox.Show("Yess");

            }
            newCon.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();
            this.Hide();
            MenuForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "WELCOME ADMIN")
            {
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "ADMIN DELIVERIES";
                DeliveriesForm.btnBackLCDeliveries.Visible = false;
            }
            else if(lblTitle.Text=="WELCOME LC")
            {
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "LC DELIVERIES";
                DeliveriesForm.btnBackdeliveriesAdmin.Visible = false;
            }
        }
    }
}
