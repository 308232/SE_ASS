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
namespace SE_ASS
{
    public partial class NewClientForm : Form
    {

        //two integers are creted in order to keep track on which number of customer are we looking at in order to be able to check last record and first record as well as adding a new customer 
        public int whichrec = 0;
        public int countrec = 0;



        System.Data.SqlClient.SqlConnection newCon;
        

        //in order to read the information and pass it to the text boxes a data adapater and data set must be set 
        DataSet dsCustomer;
        System.Data.SqlClient.SqlDataAdapter daCustomer;


        public NewClientForm()
        {
            InitializeComponent();
        }

       public void MoveRecords()
        {
            DataRow OneRecord = dsCustomer.Tables["Customers"].Rows[whichrec];

           txtboxClientID.Text = OneRecord[0].ToString();
            txtboxBusinessName.Text = OneRecord[1].ToString();
            txtboxHouseNo.Text = OneRecord[2].ToString();
            txtboxStreetName.Text = OneRecord[3].ToString();
            txtboxPostCode.Text = OneRecord[4].ToString();
            txtboxPhoneNumber.Text = OneRecord[5].ToString();
            txtboxEmail.Text = OneRecord[6].ToString();
            txtboxNotes.Text = OneRecord[7].ToString();
            txtboxAssId.Text = OneRecord[8].ToString();
            txtboxContracted.Text = OneRecord[9].ToString();

        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {
            btnUPDATE.Visible = false;

            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();
            

            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            sqlGetWhat = "SELECT * From ClientsTbl";

            try
            {
                //open the database connection 
                newCon.Open();
                //setting the data adapter and filling it with the information 
                daCustomer = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, newCon);
                daCustomer.Fill(dsCustomer, "Customers");




                MoveRecords();
                countrec = dsCustomer.Tables["Customers"].Rows.Count;
                
            }
            catch
            {
                MessageBox.Show("no connection ");

            }
            newCon.Close();
        }

        private void btnFirstRecordClientsForm_Click(object sender, EventArgs e)
        {
            whichrec = 0;
            MoveRecords();
        }

        private void btnNextRecordClientsForm_Click(object sender, EventArgs e)
        {
            if (whichrec < countrec - 1)
            {
                whichrec++;
                MoveRecords();
            }
        }

        private void btnSaveNewClientRecord_Click(object sender, EventArgs e)
        {
            DataRow OneRecord = dsCustomer.Tables["Customers"].NewRow();
            OneRecord[0] = txtboxClientID.Text;
            OneRecord[1] = txtboxBusinessName.Text;
            OneRecord[2] = txtboxHouseNo.Text;
            OneRecord[3] = txtboxStreetName.Text;
            OneRecord[4] = txtboxPostCode.Text;
            OneRecord[5] = txtboxPhoneNumber.Text;
            OneRecord[6] = txtboxEmail.Text;
            OneRecord[7] = txtboxNotes.Text;
            OneRecord[8] = txtboxAssId.Text;
            OneRecord[9] = txtboxContracted.Text;




            dsCustomer.Tables["Customers"].Rows.Add(OneRecord);
            countrec++;
            whichrec = countrec - 1;

            System.Data.SqlClient.SqlCommandBuilder myUpdateDB;
            myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daCustomer);
            myUpdateDB.DataAdapter.Update(dsCustomer.Tables["Customers"]);
            MessageBox.Show("Record Saved");

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

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            txtboxClientID.Clear();
            txtboxBusinessName.Clear();
            txtboxHouseNo.Clear();
            txtboxStreetName.Clear();
            txtboxPostCode.Clear();
            txtboxPhoneNumber.Clear();
            txtboxEmail.Clear();
            txtboxNotes.Clear();
            txtboxAssId.Clear();
            txtboxContracted.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLastRecordClientsForm_Click(object sender, EventArgs e)
        {
            whichrec = countrec - 1;
            MoveRecords();
        }

        private void btnPreviusRecordClientsForm_Click(object sender, EventArgs e)
        {
            if (whichrec > 0)
            {
                whichrec--;
                MoveRecords();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            whichrec = countrec - 1;
            MoveRecords();
        }

        private void btnPreviusRecord_Click(object sender, EventArgs e)
        {

            if (whichrec > 0)
            {
                whichrec--;
                MoveRecords();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        private void btnBackLC_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
            MainForm.lblTitle.Text = "WELCOME LC";
            MainForm.button1.Visible = false;
        }

        private void btnBackOwner_Click(object sender, EventArgs e)
        {
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

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            txtboxClientID.Enabled = false;
            btnSaveNewClientRecord.Visible = false;
            btnAddNewClient.Visible = false;
            btnUPDATE.Visible = true;

            btnFirstRecordClientsForm.Visible = false;
            btnNextRecordClientsForm.Visible = false;
            btnLastRecord.Visible = false;
            btnPreviusRecord.Visible = false;
            btnEDIT.Visible = false;
            
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {

            
            dsCustomer = new DataSet();
            

            //a private string to pass the data from the database to. 
            
            //in order to read the dataabse sql code is used as shown below 

            String Update = "UPDATE ClientsTbl SET BusinessName='"+txtboxBusinessName.Text+"', HouseNo='"+txtboxHouseNo.Text+"', StreetName='"+txtboxStreetName.Text+"', PostCode='"+txtboxPostCode.Text+"', PhoneNumber='"+txtboxPhoneNumber.Text+"', Email='"+txtboxEmail.Text+"', Notes='"+txtboxNotes.Text+"', AssID='"+txtboxAssId.Text+"', Contracted='"+txtboxContracted.Text+"' WHERE ClientID='"+txtboxClientID.Text+"'";

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
            
            conn.Close();

            btnFirstRecordClientsForm.Visible = true;
            btnNextRecordClientsForm.Visible = true;
            btnLastRecord.Visible = true;
            btnPreviusRecord.Visible = true;
            btnEDIT.Visible = true;

            btnUPDATE.Visible = false;
            btnSaveNewClientRecord.Visible = true;
            btnAddNewClient.Visible = true;
            if (label1.Text == "LC CLIENT FORM")
            {
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
            else if (label1.Text == "ADMIN CLIENT FORM")
            {
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

        }
    }
    
}
