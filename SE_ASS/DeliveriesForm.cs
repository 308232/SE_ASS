﻿using System;
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

        public int whichrec = 0;
        public int countrec = 0;

        System.Data.SqlClient.SqlConnection newCon;
        DataSet dsCustomer;
        System.Data.SqlClient.SqlDataAdapter daCustomer;



        public DeliveriesForm()
        {
            InitializeComponent();
        }
        public void MoveRecords()
        {
            DataRow OneRecord = dsCustomer.Tables["Deliveries"].Rows[whichrec];

            txtboxDeliverieID.Text = OneRecord[0].ToString();
            txtboxDeliverieHourStart.Text = OneRecord[1].ToString();
            txtboxDeliveryHourEnd.Text = OneRecord[2].ToString();
            txtboxDeliverieDayStart.Text = OneRecord[3].ToString();
            txtboxDeliverieDayEnd.Text = OneRecord[4].ToString();
            txtboxCourierID.Text = OneRecord[5].ToString();
            txtboxContracted.Text = OneRecord[6].ToString();
            

        }

        private void DeliveriesForm_Load(object sender, EventArgs e)
        {
            btnCancelAdd.Visible = false;

            newCon = new System.Data.SqlClient.SqlConnection();
            newCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Mitko Bozhilov\\Work Year 6\\Software Eng\\Ass\\MyDataBase\\MyDataBase\\BookingSystemDataBase.mdf;Integrated Security=True; Connect Timeout=30";

            dsCustomer = new DataSet();


            //a private string to pass the data from the database to. 
            String sqlGetWhat;
            //in order to read the dataabse sql code is used as shown below 
            sqlGetWhat = "SELECT * From DeliveriesTbl WHERE Contracted='n'";

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

        private void btnAddNewCourierJob_Click(object sender, EventArgs e)
        {

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

        }

        private void btnNextRecordDeliveries_Click(object sender, EventArgs e)
        {
            if (whichrec < countrec - 1)
            {
                whichrec++;
                MoveRecords();
            }
        }

        private void btnPreviousRecordDeliveries_Click(object sender, EventArgs e)
        {
            if (whichrec > 0)
            {
                whichrec--;
                MoveRecords();
            }
        }

        private void btnSaveDeliveries_Click(object sender, EventArgs e)
        {
            if (txtboxContracted.Text == "n")
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
                MessageBox.Show("New Record Has Been Added. Click on Refresh to refresh the DataBase");
            }
            else
            {
                MessageBox.Show("You have no rights to create Contracted courier jobs");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DeliveriesForm DeliveriesForm = new DeliveriesForm();
            this.Hide();
            DeliveriesForm.Show();
        }

        private void btnBackdeliveriesAdmin_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            DeliveriesForm DeliveriesForm = new DeliveriesForm();
            this.Hide();
            DeliveriesForm.Show();
        }
    }
}
