namespace IOOP_Assignment
{
    partial class ManagerTableInformationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerTableInformationPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlaceID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblMinOfPax = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblTableDesc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.lblPlaceID);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblPlaceID
            // 
            this.lblPlaceID.AutoSize = true;
            this.lblPlaceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceID.Location = new System.Drawing.Point(144, 14);
            this.lblPlaceID.Name = "lblPlaceID";
            this.lblPlaceID.Size = new System.Drawing.Size(25, 26);
            this.lblPlaceID.TabIndex = 3;
            this.lblPlaceID.Text = "#";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(358, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.LightGreen;
            this.btnReserve.Location = new System.Drawing.Point(149, 398);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(85, 40);
            this.btnReserve.TabIndex = 19;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // lblMinOfPax
            // 
            this.lblMinOfPax.AutoSize = true;
            this.lblMinOfPax.Location = new System.Drawing.Point(153, 185);
            this.lblMinOfPax.Name = "lblMinOfPax";
            this.lblMinOfPax.Size = new System.Drawing.Size(81, 20);
            this.lblMinOfPax.TabIndex = 31;
            this.lblMinOfPax.Text = "MinOfPax:";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(142, 215);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(92, 20);
            this.lblEventType.TabIndex = 32;
            this.lblEventType.Text = "Event Type:";
            // 
            // lblTableDesc
            // 
            this.lblTableDesc.AutoSize = true;
            this.lblTableDesc.Location = new System.Drawing.Point(141, 148);
            this.lblTableDesc.Name = "lblTableDesc";
            this.lblTableDesc.Size = new System.Drawing.Size(93, 20);
            this.lblTableDesc.TabIndex = 33;
            this.lblTableDesc.Text = "Description:";
            // 
            // ManagerTableInformationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lblTableDesc);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblMinOfPax);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerTableInformationPage";
            this.Text = "ManagerTableInformationPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaceID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblMinOfPax;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblTableDesc;

    }
}