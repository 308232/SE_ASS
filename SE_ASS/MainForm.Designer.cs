
namespace SE_ASS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreateNewClientContract = new System.Windows.Forms.Button();
            this.btnShowAllAssForACourierForADAY = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.comboboxWhichday = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxStartDate = new System.Windows.Forms.TextBox();
            this.txtboxEndDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllCAss = new System.Windows.Forms.Button();
            this.txtboxCourierID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxCourierdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(375, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WELCOME ADMIN";
            // 
            // btnCreateNewClientContract
            // 
            this.btnCreateNewClientContract.Location = new System.Drawing.Point(22, 284);
            this.btnCreateNewClientContract.Name = "btnCreateNewClientContract";
            this.btnCreateNewClientContract.Size = new System.Drawing.Size(97, 51);
            this.btnCreateNewClientContract.TabIndex = 1;
            this.btnCreateNewClientContract.Text = "CLIENT CONTRACT";
            this.btnCreateNewClientContract.UseVisualStyleBackColor = true;
            this.btnCreateNewClientContract.Click += new System.EventHandler(this.btnCreateNewClientContract_Click);
            // 
            // btnShowAllAssForACourierForADAY
            // 
            this.btnShowAllAssForACourierForADAY.BackColor = System.Drawing.SystemColors.Menu;
            this.btnShowAllAssForACourierForADAY.ForeColor = System.Drawing.Color.Crimson;
            this.btnShowAllAssForACourierForADAY.Location = new System.Drawing.Point(245, 157);
            this.btnShowAllAssForACourierForADAY.Name = "btnShowAllAssForACourierForADAY";
            this.btnShowAllAssForACourierForADAY.Size = new System.Drawing.Size(110, 80);
            this.btnShowAllAssForACourierForADAY.TabIndex = 2;
            this.btnShowAllAssForACourierForADAY.Text = "Obtain a report for all assignments \r\nfor all \r\ncouriers for the current month";
            this.btnShowAllAssForACourierForADAY.UseVisualStyleBackColor = false;
            this.btnShowAllAssForACourierForADAY.Click += new System.EventHandler(this.btnShowAllAssForACourierForADAY_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(199, 318);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(786, 239);
            this.dataGridViewAdmin.TabIndex = 3;
            // 
            // comboboxWhichday
            // 
            this.comboboxWhichday.FormattingEnabled = true;
            this.comboboxWhichday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednsday\t",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboboxWhichday.Location = new System.Drawing.Point(802, 12);
            this.comboboxWhichday.Name = "comboboxWhichday";
            this.comboboxWhichday.Size = new System.Drawing.Size(132, 21);
            this.comboboxWhichday.TabIndex = 4;
            this.comboboxWhichday.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(-2, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 95);
            this.label1.TabIndex = 5;
            this.label1.Text = "ENTER DATES IN THE\r\nTEXT BOXES TO SEARCH \r\nBETWEEN A PERIOD OF DAYS\r\nDATE FORMAT " +
    "IS: YYYY-MM-DD\r\n\r\n";
            // 
            // txtboxStartDate
            // 
            this.txtboxStartDate.Location = new System.Drawing.Point(309, 254);
            this.txtboxStartDate.Name = "txtboxStartDate";
            this.txtboxStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtboxStartDate.TabIndex = 6;
            // 
            // txtboxEndDate
            // 
            this.txtboxEndDate.Location = new System.Drawing.Point(476, 250);
            this.txtboxEndDate.Name = "txtboxEndDate";
            this.txtboxEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtboxEndDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "StartDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "EndDate";
            // 
            // btnAllCAss
            // 
            this.btnAllCAss.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAllCAss.ForeColor = System.Drawing.Color.Crimson;
            this.btnAllCAss.Location = new System.Drawing.Point(779, 164);
            this.btnAllCAss.Name = "btnAllCAss";
            this.btnAllCAss.Size = new System.Drawing.Size(100, 73);
            this.btnAllCAss.TabIndex = 10;
            this.btnAllCAss.Text = "Obtain a report for all\r\n assignments for a\r\n courier for that day";
            this.btnAllCAss.UseVisualStyleBackColor = false;
            this.btnAllCAss.Click += new System.EventHandler(this.btnAllCAss_Click);
            // 
            // txtboxCourierID
            // 
            this.txtboxCourierID.Location = new System.Drawing.Point(719, 250);
            this.txtboxCourierID.Name = "txtboxCourierID";
            this.txtboxCourierID.Size = new System.Drawing.Size(100, 20);
            this.txtboxCourierID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(596, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 48);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Courier ID AND Date \r\nin the \r\ntext box to search ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "CourierID:";
            // 
            // txtboxCourierdate
            // 
            this.txtboxCourierdate.Location = new System.Drawing.Point(885, 250);
            this.txtboxCourierdate.Name = "txtboxCourierdate";
            this.txtboxCourierdate.Size = new System.Drawing.Size(100, 20);
            this.txtboxCourierdate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 80);
            this.button1.TabIndex = 16;
            this.button1.Text = "Obtain a report for all assignments \r\nshowing contracts and non-contract\r\n client" +
    "s for a given month";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 578);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 39);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 53);
            this.button2.TabIndex = 18;
            this.button2.Text = "Create courier jobs  ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1188, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxCourierdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxCourierID);
            this.Controls.Add(this.btnAllCAss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxEndDate);
            this.Controls.Add(this.txtboxStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboboxWhichday);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.btnShowAllAssForACourierForADAY);
            this.Controls.Add(this.btnCreateNewClientContract);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.ComboBox comboboxWhichday;
        public System.Windows.Forms.Button btnAllCAss;
        public System.Windows.Forms.TextBox txtboxCourierID;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TextBox txtboxCourierdate;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnCreateNewClientContract;
        public System.Windows.Forms.Button btnShowAllAssForACourierForADAY;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtboxStartDate;
        public System.Windows.Forms.TextBox txtboxEndDate;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}