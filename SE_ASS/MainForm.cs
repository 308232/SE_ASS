using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//adding needed libraries 

using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace SE_ASS
{
    public partial class MainForm : Form
    {
        //creating the sql connection 

        System.Data.SqlClient.SqlConnection newCon;
        //creating the dataset 

        DataSet dsCustomer;

        //creating the sqldata adapter 

        System.Data.SqlClient.SqlDataAdapter daCustomer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewClientContract_Click(object sender, EventArgs e)
        {
            
            //hiding, showing the correct buttons depending on the label text that we changed when logged in  Owner
            if (lblTitle.Text == "WELCOME OWNER")
            {
                NewClientForm NewClientForm = new NewClientForm();
                NewClientForm.btnBackLC.Visible = false;
                NewClientForm.btnBack.Visible = false;
                NewClientForm.btnAddNewClient.Visible = false;
                NewClientForm.btnSaveNewClientRecord.Visible = false;
                NewClientForm.btnEDIT.Visible = false;
                NewClientForm.btnUPDATE.Visible = false;
                NewClientForm.label1.Text = "Owner CLIENT FORM";
                
                this.Hide();
                NewClientForm.Show();
            }
            else if(lblTitle.Text=="WELCOME ADMIN")
            {
                //hiding, showing the correct buttons depending on the label text that we changed when logged in  Admin

                NewClientForm NewClientForm = new NewClientForm();
                NewClientForm.btnBackLC.Visible = false;
                NewClientForm.btnBackOwner.Visible = false;
                NewClientForm.btnAddNewClient.Visible = true;
                NewClientForm.btnSaveNewClientRecord.Visible = true;
                NewClientForm.btnEDIT.Visible = true;
                NewClientForm.btnUPDATE.Visible = false;
                NewClientForm.label1.Text = "ADMIN CLIENT FORM";
                this.Hide();
                NewClientForm.Show();
            }
            else if (lblTitle.Text == "WELCOME LC")
            {
                //hiding, showing the correct buttons depending on the label text that we changed when logged in LC
                NewClientForm NewClientForm = new NewClientForm();
                NewClientForm.btnBack.Visible = false;
                NewClientForm.btnBackLC.Visible = true;
                NewClientForm.btnBackOwner.Visible = false;
                NewClientForm.btnAddNewClient.Visible = false;
                NewClientForm.btnSaveNewClientRecord.Visible = false;
                NewClientForm.btnEDIT.Visible = true;
                NewClientForm.btnUPDATE.Visible = false;
                NewClientForm.label1.Text = "LC CLIENT FORM";

                this.Hide();
                NewClientForm.Show();
            }
        }

        //button for showing all Assignments for a courier for a choosen day 
        private void btnShowAllAssForACourierForADAY_Click(object sender, EventArgs e)
        {
           
            //creating a new database sql connection called newCon

            newCon = new System.Data.SqlClient.SqlConnection();
            //path to the database
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            //sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart ='2021-03-10'";
            //sql command that takes the values from two text boxes and displayes data
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
                //message showing that there is no connection to the databse if an error occurs 

                MessageBox.Show("Yess");

            }
            //closing the connection 
            newCon.Close();
        }

        private void btnAllCAss_Click(object sender, EventArgs e)
        {

            //creating a new database sql connection called newCon
            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            
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
                //message showing that there is no connection to the databse if an error occurs 
                MessageBox.Show("There is no connection to the database");

            }
            //closing the connection 
            newCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating a new database sql connection called newCon

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
            //closing the connection 
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
            //if for checking the title text 
            
            if (lblTitle.Text == "WELCOME ADMIN")
            {
                //hiding, showing the correct buttons depending on the label text that we changed when logged in Admin and loads the delivery form with changed title label  
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "ADMIN DELIVERIES";
                DeliveriesForm.btnEditLCDeliveries.Visible = false;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = false;
                DeliveriesForm.btnBackLCDeliveries.Visible = false;
            }
            else if(lblTitle.Text=="WELCOME LC")
            {
                //hiding, showing the correct buttons depending on the label text that we changed when logged in LC and loads the delivery form with changed title label 
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "LC DELIVERIES";
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = true;
                DeliveriesForm.btnBackLCDeliveries.Visible = true;
                DeliveriesForm.btnBackdeliveriesAdmin.Visible = false;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = false;

            }
        }

        private void btnCourierAss_Click(object sender, EventArgs e)
        {
            //hiding, showing the correct buttons depending on the label text that we changed when logged in Admin and loads the courier form 
            CourierAssForm CourierAssForm = new CourierAssForm();
            this.Hide();
            CourierAssForm.Show();
            CourierAssForm.txtboxDeliverieIDC.Enabled = false;
            CourierAssForm.txtboxDeliverieHourStartC.Enabled = false;
            CourierAssForm.txtboxDeliveryHourEndC.Enabled = false;
            CourierAssForm.txtboxDeliverieDayStartC.Enabled = false;
            CourierAssForm.txtboxDeliverieDayEndC.Enabled = false;
            CourierAssForm.txtboxContractedC.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
