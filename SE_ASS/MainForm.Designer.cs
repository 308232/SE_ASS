
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(287, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WELCOME";
            // 
            // btnCreateNewClientContract
            // 
            this.btnCreateNewClientContract.Location = new System.Drawing.Point(97, 118);
            this.btnCreateNewClientContract.Name = "btnCreateNewClientContract";
            this.btnCreateNewClientContract.Size = new System.Drawing.Size(107, 59);
            this.btnCreateNewClientContract.TabIndex = 1;
            this.btnCreateNewClientContract.Text = "CREATE NEW CLIENT CONTRACT";
            this.btnCreateNewClientContract.UseVisualStyleBackColor = true;
            this.btnCreateNewClientContract.Click += new System.EventHandler(this.btnCreateNewClientContract_Click);
            // 
            // btnShowAllAssForACourierForADAY
            // 
            this.btnShowAllAssForACourierForADAY.Location = new System.Drawing.Point(505, 139);
            this.btnShowAllAssForACourierForADAY.Name = "btnShowAllAssForACourierForADAY";
            this.btnShowAllAssForACourierForADAY.Size = new System.Drawing.Size(117, 80);
            this.btnShowAllAssForACourierForADAY.TabIndex = 2;
            this.btnShowAllAssForACourierForADAY.Text = "Show All Ass for a courier";
            this.btnShowAllAssForACourierForADAY.UseVisualStyleBackColor = true;
            this.btnShowAllAssForACourierForADAY.Click += new System.EventHandler(this.btnShowAllAssForACourierForADAY_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(351, 248);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(498, 168);
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
            this.comboboxWhichday.Location = new System.Drawing.Point(661, 189);
            this.comboboxWhichday.Name = "comboboxWhichday";
            this.comboboxWhichday.Size = new System.Drawing.Size(132, 21);
            this.comboboxWhichday.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a date from the dropdown box \r\nand then press the button \r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 450);
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

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateNewClientContract;
        private System.Windows.Forms.Button btnShowAllAssForACourierForADAY;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.ComboBox comboboxWhichday;
        private System.Windows.Forms.Label label1;
    }
}