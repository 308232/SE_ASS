
namespace SE_ASS
{
    partial class LcForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditCustomerContracts = new System.Windows.Forms.Button();
            this.btnBackLc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LC FORM";
            // 
            // btnEditCustomerContracts
            // 
            this.btnEditCustomerContracts.Location = new System.Drawing.Point(142, 171);
            this.btnEditCustomerContracts.Name = "btnEditCustomerContracts";
            this.btnEditCustomerContracts.Size = new System.Drawing.Size(91, 60);
            this.btnEditCustomerContracts.TabIndex = 1;
            this.btnEditCustomerContracts.Text = "EDIT VIEW \r\nCUSTOMER CONTRACTS";
            this.btnEditCustomerContracts.UseVisualStyleBackColor = true;
            this.btnEditCustomerContracts.Click += new System.EventHandler(this.btnEditCustomerContracts_Click);
            // 
            // btnBackLc
            // 
            this.btnBackLc.Location = new System.Drawing.Point(67, 378);
            this.btnBackLc.Name = "btnBackLc";
            this.btnBackLc.Size = new System.Drawing.Size(75, 23);
            this.btnBackLc.TabIndex = 2;
            this.btnBackLc.Text = "BACK";
            this.btnBackLc.UseVisualStyleBackColor = true;
            this.btnBackLc.Click += new System.EventHandler(this.btnBackLc_Click);
            // 
            // LcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackLc);
            this.Controls.Add(this.btnEditCustomerContracts);
            this.Controls.Add(this.label1);
            this.Name = "LcForm";
            this.Text = "LcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCustomerContracts;
        private System.Windows.Forms.Button btnBackLc;
    }
}