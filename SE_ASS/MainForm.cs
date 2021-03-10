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
            NewClientForm NewClientForm = new NewClientForm();
            this.Hide();
            NewClientForm.Show();
        }

        private void btnShowAllAssForACourierForADAY_Click(object sender, EventArgs e)
        {
            String WhichDay;
            WhichDay = comboboxWhichday.Text;
            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            sqlGetWhat = "SELECT * FROM DeliveriesTbl WHERE DeliveryDayStart = '"+comboboxWhichday.Text+"'";

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
    }
}
