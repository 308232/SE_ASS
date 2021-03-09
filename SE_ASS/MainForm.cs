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
    public partial class MainForm : Form
    {
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
    }
}
