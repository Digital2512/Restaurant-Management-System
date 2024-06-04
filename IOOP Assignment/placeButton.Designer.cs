namespace IOOP_Assignment
{
    partial class placeButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placeButton));
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblMinOfPaxTitle = new System.Windows.Forms.Label();
            this.lblMinOfPax = new System.Windows.Forms.Label();
            this.lblEventsTitle = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblDescriptions = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlaceID = new System.Windows.Forms.Label();
            this.placeImagePBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeImagePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceName.Location = new System.Drawing.Point(155, 30);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(80, 29);
            this.lblPlaceName.TabIndex = 11;
            this.lblPlaceName.Text = "Hall 1";
            // 
            // lblMinOfPaxTitle
            // 
            this.lblMinOfPaxTitle.AutoSize = true;
            this.lblMinOfPaxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinOfPaxTitle.Location = new System.Drawing.Point(156, 67);
            this.lblMinOfPaxTitle.Name = "lblMinOfPaxTitle";
            this.lblMinOfPaxTitle.Size = new System.Drawing.Size(105, 20);
            this.lblMinOfPaxTitle.TabIndex = 12;
            this.lblMinOfPaxTitle.Text = "Min Of Pax: ";
            // 
            // lblMinOfPax
            // 
            this.lblMinOfPax.AutoSize = true;
            this.lblMinOfPax.Location = new System.Drawing.Point(267, 67);
            this.lblMinOfPax.Name = "lblMinOfPax";
            this.lblMinOfPax.Size = new System.Drawing.Size(80, 20);
            this.lblMinOfPax.TabIndex = 13;
            this.lblMinOfPax.Text = "20 People";
            this.lblMinOfPax.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEventsTitle
            // 
            this.lblEventsTitle.AutoSize = true;
            this.lblEventsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsTitle.Location = new System.Drawing.Point(516, 25);
            this.lblEventsTitle.Name = "lblEventsTitle";
            this.lblEventsTitle.Size = new System.Drawing.Size(74, 20);
            this.lblEventsTitle.TabIndex = 14;
            this.lblEventsTitle.Text = "Events: ";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(596, 23);
            this.lblEvents.MaximumSize = new System.Drawing.Size(110, 60);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(88, 60);
            this.lblEvents.TabIndex = 15;
            this.lblEvents.Text = "Party, Birthday, Gatherings";
            // 
            // lblDescriptions
            // 
            this.lblDescriptions.AutoSize = true;
            this.lblDescriptions.Location = new System.Drawing.Point(155, 100);
            this.lblDescriptions.MaximumSize = new System.Drawing.Size(425, 50);
            this.lblDescriptions.Name = "lblDescriptions";
            this.lblDescriptions.Size = new System.Drawing.Size(425, 50);
            this.lblDescriptions.TabIndex = 16;
            this.lblDescriptions.Text = resources.GetString("lblDescriptions.Text");
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(-4, -3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(46, 52);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(661, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 49);
            this.panel1.TabIndex = 18;
            // 
            // lblPlaceID
            // 
            this.lblPlaceID.AutoSize = true;
            this.lblPlaceID.Location = new System.Drawing.Point(156, 10);
            this.lblPlaceID.Name = "lblPlaceID";
            this.lblPlaceID.Size = new System.Drawing.Size(77, 20);
            this.lblPlaceID.TabIndex = 19;
            this.lblPlaceID.Text = "HALL001";
            // 
            // placeImagePBox
            // 
            this.placeImagePBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.placeImagePBox.Location = new System.Drawing.Point(0, 0);
            this.placeImagePBox.Name = "placeImagePBox";
            this.placeImagePBox.Size = new System.Drawing.Size(150, 150);
            this.placeImagePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.placeImagePBox.TabIndex = 10;
            this.placeImagePBox.TabStop = false;
            // 
            // placeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPlaceID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescriptions);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblEventsTitle);
            this.Controls.Add(this.lblMinOfPax);
            this.Controls.Add(this.lblMinOfPaxTitle);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.placeImagePBox);
            this.Name = "placeButton";
            this.Size = new System.Drawing.Size(700, 150);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.placeImagePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox placeImagePBox;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblMinOfPaxTitle;
        private System.Windows.Forms.Label lblMinOfPax;
        private System.Windows.Forms.Label lblEventsTitle;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblDescriptions;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaceID;
    }
}
