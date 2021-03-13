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
    public partial class CourierAssForm : Form
    {


        public int whichrec = 0;
        public int countrec = 0;

        System.Data.SqlClient.SqlConnection newCon;
        DataSet dsCustomer;
        System.Data.SqlClient.SqlDataAdapter daCustomer;

        public CourierAssForm()
        {
            InitializeComponent();
        }
        public void MoveRecords()
        {
            DataRow OneRecord = dsCustomer.Tables["Deliveries"].Rows[whichrec];

            txtboxDeliverieIDC.Text = OneRecord[0].ToString();
            txtboxDeliverieHourStartC.Text = OneRecord[1].ToString();
            txtboxDeliveryHourEndC.Text = OneRecord[2].ToString();
            txtboxDeliverieDayStartC.Text = OneRecord[3].ToString();
            txtboxDeliverieDayEndC.Text = OneRecord[4].ToString();
            txtboxCourierIDC.Text = OneRecord[5].ToString();
            txtboxContractedC.Text = OneRecord[6].ToString();


        }
        private void CourierAssForm_Load(object sender, EventArgs e)
        {
            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";
           
            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            sqlGetWhat = "SELECT * From DeliveriesTbl WHERE CourierID='0'";

            try
            {
                //open the database connection 
                newCon.Open();
                //setting the data adapter and filling it with the information 
                daCustomer = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, newCon);
                daCustomer.Fill(dsCustomer, "Deliveries");



                MoveRecords();
                countrec = dsCustomer.Tables["Deliveries"].Rows.Count;


            }
            catch
            {
                MessageBox.Show("no connection ");

            }
            newCon.Close();



        }

        private void btnNextRecordC_Click(object sender, EventArgs e)
        {
            if (whichrec < countrec - 1)
            {
                whichrec++;
                MoveRecords();
            }
        }

        private void btnPreviousRecordC_Click(object sender, EventArgs e)
        {

            if (whichrec > 0)
            {
                whichrec--;
                MoveRecords();
            }
        }

        private void btnAcceptAssC_Click(object sender, EventArgs e)
        {
            String Update = "UPDATE DeliveriesTbl SET CourierID='" + txtboxCourierIDC.Text + "' WHERE DeliveriesID='" + txtboxDeliverieIDC.Text + "'";

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

        private void btnBackC_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
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
    }
}
