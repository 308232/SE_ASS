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

        private void MoveRecords()
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
           
        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Yess");

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

          


            dsCustomer.Tables["Customers"].Rows.Add(OneRecord);
            countrec++;
            whichrec = countrec - 1;

            System.Data.SqlClient.SqlCommandBuilder myUpdateDB;
            myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daCustomer);
            myUpdateDB.DataAdapter.Update(dsCustomer.Tables["Customers"]);
            
            MoveRecords();
            
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
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
    
}
