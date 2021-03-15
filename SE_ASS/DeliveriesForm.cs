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
    public partial class DeliveriesForm : Form
    {
        //two integers are creted in order to keep track on which number of customer are we looking at in order to be able to check last record and first record as well as adding a new customer 
        public int whichrec = 0;
        public int countrec = 0;

        System.Data.SqlClient.SqlConnection newCon;
        //in order to read the information and pass it to the text boxes a data adapater and data set must be set 
        DataSet dsCustomer;
        System.Data.SqlClient.SqlDataAdapter daCustomer;



        public DeliveriesForm()
        {
            InitializeComponent();
        }
        public void MoveRecords()
        {
            //a method for navigationg between records 

            DataRow OneRecord = dsCustomer.Tables["Deliveries"].Rows[whichrec];

            //populating the textboxes with matching data from the database
            txtboxDeliverieID.Text = OneRecord[0].ToString();
            txtboxDeliverieHourStart.Text = OneRecord[1].ToString();
            txtboxDeliveryHourEnd.Text = OneRecord[2].ToString();
            txtboxDeliverieDayStart.Text = OneRecord[3].ToString();
            txtboxDeliverieDayEnd.Text = OneRecord[4].ToString();
            txtboxCourierID.Text = OneRecord[5].ToString();
            txtboxContracted.Text = OneRecord[6].ToString();
            

        }

        public void DeliveriesForm_Load(object sender, EventArgs e)
        {

           
                btnCancelAdd.Visible = false;
            //On form load loads the connection to the database and gets all the data from the Clients Tbl in order to display the records 

            newCon = new System.Data.SqlClient.SqlConnection();
                newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

                dsCustomer = new DataSet();


                //a private string to pass the data from the database to. 
                String sqlGetWhat;
                //in order to read the dataabse sql code is used as shown below 
                sqlGetWhat = "SELECT * From DeliveriesTbl ";

                try
                {
                    //open the database connection 
                    newCon.Open();
                    //setting the data adapter and filling it with the information 
                    daCustomer = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, newCon);
                    daCustomer.Fill(dsCustomer, "Deliveries");


                //calling move records method created above to display the data inot the text boxes 

                     MoveRecords();
                    countrec = dsCustomer.Tables["Deliveries"].Rows.Count;


                }
                catch
                {
                //message if there is no connection with the database 
                MessageBox.Show("no connection ");

                }
                newCon.Close();
            
            
            

        }

        public void btnAddNewCourierJob_Click(object sender, EventArgs e)
        {
            //pressing the buttons clears the textboxes and hides some of the buttons in order for the user to add a new job 

            btnSaveDeliveries.Visible = true;
            btnPreviousRecordDeliveries.Visible = false;
            btnNextRecordDeliveries.Visible = false;
            btnAddNewCourierJob.Visible = false;

            txtboxDeliverieID.Clear();
            txtboxDeliverieHourStart.Clear();
            txtboxDeliveryHourEnd.Clear();
            txtboxDeliverieDayStart.Clear();
            txtboxDeliverieDayEnd.Clear();
            txtboxCourierID.Clear();
            txtboxContracted.Clear();
            btnRefresh.Visible = false;
            btnCancelAdd.Visible = true;
            btnDeleteDeliverie.Visible = false;
            btnEditLCDeliveries.Visible = false;
            btnSaveEditDeliveryLC.Visible = false;

        }

       public void btnNextRecordDeliveries_Click(object sender, EventArgs e)
        {
            if (whichrec < countrec - 1)
            {
                whichrec++;
                MoveRecords();
            }
        }

        public void btnPreviousRecordDeliveries_Click(object sender, EventArgs e)
        {
            if (whichrec > 0)
            {
                whichrec--;
                MoveRecords();
            }
        }

        public void btnSaveDeliveries_Click(object sender, EventArgs e)
        {
             //if checking if the new delivery job created is from contracted or non contracted client . Admin can add only non contracted client 
            if (txtboxContracted.Text == "n" && label1.Text=="ADMIN DELIVERIES")
            {
                DateTime startTime = Convert.ToDateTime("08:30");
                DateTime endTime = Convert.ToDateTime("16:30");
                DateTime cStartTime = Convert.ToDateTime(txtboxDeliverieHourStart.Text);
                DateTime cEndtTime = Convert.ToDateTime(txtboxDeliveryHourEnd.Text);
                //another if making sure that the time that has been enetered is inside the working hours of the company 08:30-16:30
                if (cStartTime > startTime && cEndtTime < endTime)
                {
                    //if the time is correct creates the new record 

                    DataRow OneRecord = dsCustomer.Tables["Deliveries"].NewRow();
                    OneRecord[0] = txtboxDeliverieID.Text;
                    OneRecord[1] = txtboxDeliverieHourStart.Text;
                    OneRecord[2] = txtboxDeliveryHourEnd.Text;
                    OneRecord[3] = txtboxDeliverieDayStart.Text;
                    OneRecord[4] = txtboxDeliverieDayEnd.Text;
                    OneRecord[5] = txtboxCourierID.Text;
                    OneRecord[6] = txtboxContracted.Text;





                    dsCustomer.Tables["Deliveries"].Rows.Add(OneRecord);


                    System.Data.SqlClient.SqlCommandBuilder myUpdateDB;
                    myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daCustomer);
                    myUpdateDB.DataAdapter.Update(dsCustomer.Tables["Deliveries"]);

                    btnNextRecordDeliveries.Visible = true;
                    btnPreviousRecordDeliveries.Visible = true;
                    btnSaveDeliveries.Visible = false;
                    btnAddNewCourierJob.Visible = true;
                    btnRefresh.Visible = true;
                    btnCancelAdd.Visible = false;
                    btnSaveEditDeliveryLC.Visible = false;
                    btnEditLCDeliveries.Visible = false;
                    MessageBox.Show("New Record Has Been Added. Click on Refresh to refresh the DataBase");
                }
                else
                {
                    //mesage if the time entered is wrong 
                    MessageBox.Show("The Time must be between 08:30 and 16:30");
                }
                
            }
            else if(txtboxContracted.Text == "y" && label1.Text == "LC DELIVERIES")
            {
                //the else if contracted job is added 

                DateTime startTime = Convert.ToDateTime("08:30");
                DateTime endTime = Convert.ToDateTime("16:30");
                DateTime cStartTime = Convert.ToDateTime(txtboxDeliverieHourStart.Text);
                DateTime cEndtTime = Convert.ToDateTime(txtboxDeliveryHourEnd.Text);

                //again checks about the time if its between 8:30-16:30 and then creates the record 
                if (cStartTime > startTime && cEndtTime < endTime)
                {
                    DataRow OneRecord = dsCustomer.Tables["Deliveries"].NewRow();
                    OneRecord[0] = txtboxDeliverieID.Text;
                    OneRecord[1] = txtboxDeliverieHourStart.Text;
                    OneRecord[2] = txtboxDeliveryHourEnd.Text;
                    OneRecord[3] = txtboxDeliverieDayStart.Text;
                    OneRecord[4] = txtboxDeliverieDayEnd.Text;
                    OneRecord[5] = txtboxCourierID.Text;
                    OneRecord[6] = txtboxContracted.Text;





                    dsCustomer.Tables["Deliveries"].Rows.Add(OneRecord);


                    System.Data.SqlClient.SqlCommandBuilder myUpdateDB;
                    myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daCustomer);
                    myUpdateDB.DataAdapter.Update(dsCustomer.Tables["Deliveries"]);

                    btnNextRecordDeliveries.Visible = true;
                    btnPreviousRecordDeliveries.Visible = true;
                    btnSaveDeliveries.Visible = false;
                    btnAddNewCourierJob.Visible = true;
                    btnRefresh.Visible = true;
                    btnCancelAdd.Visible = false;
                    btnSaveEditDeliveryLC.Visible = true;
                    btnEditLCDeliveries.Visible = true;
                    btnSaveEditDeliveryLC.Visible = false;
                    MessageBox.Show("New Record Has Been Added. Click on Refresh to refresh the DataBase");
                }
                else
                {
                    MessageBox.Show("Delivery times must be betwen 08:30 and 16:30");
                }
            }
            else
            {
                MessageBox.Show("You have no rights to perform this");
            }
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            //a refresh button in order to refresh the data from the database
            //if statemnet checking for the text in the title label so after refreshing will load the form with all matching properties for the user that is logged in 
            if (label1.Text == "LC DELIVERIES")
            {

                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "LC DELIVERIES";
                DeliveriesForm.btnBackLCDeliveries.Visible = true;
                DeliveriesForm.btnBackdeliveriesAdmin.Visible = false;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = true;
                DeliveriesForm.btnEditLCDeliveries.Visible = true;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = false;
            }
            else if(label1.Text == "ADMIN DELIVERIES")
            {
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "ADMIN DELIVERIES";
                DeliveriesForm.btnBackLCDeliveries.Visible = false;
                DeliveriesForm.btnBackdeliveriesAdmin.Visible = true;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = false;
                DeliveriesForm.btnEditLCDeliveries.Visible = false;
            }
         }

       public void btnBackdeliveriesAdmin_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        public void btnCancelAdd_Click(object sender, EventArgs e)
        {
            //if for canceling to add a new delivery and checking who is logged in 
            if (label1.Text == "LC DELIVERIES")
            {
               //depending on who is logged in hides and shows buttons when loading the form 
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "LC DELIVERIES";
                DeliveriesForm.btnBackLCDeliveries.Visible = true;
                DeliveriesForm.btnBackdeliveriesAdmin.Visible = false;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = true;
                DeliveriesForm.btnBackLCDeliveries.Visible = true;
                DeliveriesForm.btnSaveDeliveries.Visible = false;
                DeliveriesForm.btnCancelAdd.Visible = false;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = false;
            }
            else if (label1.Text == "ADMIN DELIVERIES")
            {
                //depending on who is logged in hides and shows buttons when loading the form 
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "ADMIN DELIVERIES";
                DeliveriesForm.btnBackLCDeliveries.Visible = false;
                DeliveriesForm.btnBackdeliveriesAdmin.Visible = true;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = false;
                DeliveriesForm.btnBackLCDeliveries.Visible = false;
            }
        }

        public void btnBackLCDeliveries_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
            MainForm.lblTitle.Text = "WELCOME LC";
            MainForm.button1.Visible = false;
        }

       public void btnDeleteDeliverie_Click(object sender, EventArgs e)
        {

            //setting DataSet to populate with the data I use the same name as in my customer form 
            dsCustomer = new DataSet();


            

            //in order to read the dataabse sql code is used as shown below 

            String Update = "DELETE FROM DeliveriesTbl WHERE DeliveriesID='"+txtboxDeliverieID.Text+"'";


            //seting a new sql connection based on my already loaded one 
            SqlConnection conn = new SqlConnection(newCon.ConnectionString);
            SqlCommand cmd = new SqlCommand(Update, conn);
            SqlDataReader read;

            //try and catch n order to confirm if the record has been deleted 
            try
            {
                //open the database connection 
                conn.Open();
                //read the cmd reader and assign to read
                read = cmd.ExecuteReader();
                MessageBox.Show("Record Deleted");

            }
            catch
            {
                MessageBox.Show("Not able to Delete the record from the databse ");

            }

            conn.Close();
            //if checking the titile label so it will load the corect functions when the delete button is pressed 
            if (label1.Text == "ADMIN DELIVERIES")
            {
                DeliveriesForm DeliveriesForm = new DeliveriesForm();
                this.Hide();
                DeliveriesForm.Show();
                DeliveriesForm.label1.Text = "ADMIN DELIVERIES";
                DeliveriesForm.btnEditLCDeliveries.Visible = false;
                DeliveriesForm.btnSaveEditDeliveryLC.Visible = false;
                DeliveriesForm.btnBackLCDeliveries.Visible = false;
            }
            else if (label1.Text == "LC DELIVERIES")
            {
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

        public void btnEditLCDeliveries_Click(object sender, EventArgs e)
        {
            txtboxDeliverieID.Enabled = false;
            btnNextRecordDeliveries.Visible = false;
            btnPreviousRecordDeliveries.Visible = false;
            btnDeleteDeliverie.Visible = false;
            btnAddNewCourierJob.Visible = false;
            btnSaveEditDeliveryLC.Visible = true;
            btnEditLCDeliveries.Visible = false;




        }

       public void btnSaveEditDeliveryLC_Click(object sender, EventArgs e)
        {
            DateTime startTime = Convert.ToDateTime("08:30");
            DateTime endTime = Convert.ToDateTime("16:30");
            DateTime cStartTime = Convert.ToDateTime(txtboxDeliverieHourStart.Text);
            DateTime cEndtTime = Convert.ToDateTime(txtboxDeliveryHourEnd.Text);

            if (cStartTime > startTime && cEndtTime < endTime)
            {
                String Update = "UPDATE DeliveriesTbl SET DeliveryHoursStart='" + txtboxDeliverieHourStart.Text + "', DeliveryHoursEnd='" + txtboxDeliveryHourEnd.Text + "', DeliveryDayStart='" + txtboxDeliverieDayStart.Text + "', DeliveryDayEnd='" + txtboxDeliverieDayEnd.Text + "', CourierID='" + txtboxCourierID.Text + "', Contracted='" + txtboxContracted.Text + "' WHERE DeliveriesID='" + txtboxDeliverieID.Text + "'";

                SqlConnection conn = new SqlConnection(newCon.ConnectionString);
                SqlCommand cmd = new SqlCommand(Update, conn);
                SqlDataReader read;


                try
                {
                    //open the database connection 

                    conn.Open();
                    read = cmd.ExecuteReader();
                    MessageBox.Show("Record Updated");


                }
                catch
                {
                    MessageBox.Show("Not able to update the databse ");

                }
                //closing the databse connection 
                conn.Close();
                //if checking which form properties to load when the editsave button is pressed  

                

                if (label1.Text == "LC DELIVERIES")
                {
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
            else
            {
                MessageBox.Show("Delivery times must be betwen 08:30 and 16:30"); 
            }
            
           
            
        }
    }
}
