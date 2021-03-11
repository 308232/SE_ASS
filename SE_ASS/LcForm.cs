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
    public partial class LcForm : Form
    {
        public LcForm()
        {
            InitializeComponent();
        }

        private void btnEditCustomerContracts_Click(object sender, EventArgs e)
        {
            NewClientForm NewClientForm = new NewClientForm();
            NewClientForm.btnAddNewClient.Visible = false;
            NewClientForm.btnSaveNewClientRecord.Visible = false;
            NewClientForm.btnBack.Visible = false;
            NewClientForm.btnBackOwner.Visible = false;
            NewClientForm.btnEDIT.Visible = true;
            NewClientForm.btnUPDATE.Visible = true;
            this.Hide();
            NewClientForm.Show();
        }

        private void btnBackLc_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();
            this.Hide();
            MenuForm.Show();
        }
    }
}
