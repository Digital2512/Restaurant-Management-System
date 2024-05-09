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
            this.placeImagePBox = new System.Windows.Forms.PictureBox();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblMinOfPaxTitle = new System.Windows.Forms.Label();
            this.lblMinOfPax = new System.Windows.Forms.Label();
            this.lblEventsTitle = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblDescriptions = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.placeImagePBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeImagePBox
            // 
            this.placeImagePBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.placeImagePBox.Image = global::IOOP_Assignment.Properties.Resources.pastaImage;
            this.placeImagePBox.Location = new System.Drawing.Point(0, 0);
            this.placeImagePBox.Name = "placeImagePBox";
            this.placeImagePBox.Size = new System.Drawing.Size(150, 150);
            this.placeImagePBox.TabIndex = 10;
            this.placeImagePBox.TabStop = false;
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPlaceName.Location = new System.Drawing.Point(157, 10);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(74, 29);
            this.lblPlaceName.TabIndex = 11;
            this.lblPlaceName.Text = "Hall 1";
            // 
            // lblMinOfPaxTitle
            // 
            this.lblMinOfPaxTitle.AutoSize = true;
            this.lblMinOfPaxTitle.Location = new System.Drawing.Point(156, 45);
            this.lblMinOfPaxTitle.Name = "lblMinOfPaxTitle";
            this.lblMinOfPaxTitle.Size = new System.Drawing.Size(93, 20);
            this.lblMinOfPaxTitle.TabIndex = 12;
            this.lblMinOfPaxTitle.Text = "Min Of Pax: ";
            // 
            // lblMinOfPax
            // 
            this.lblMinOfPax.AutoSize = true;
            this.lblMinOfPax.Location = new System.Drawing.Point(157, 68);
            this.lblMinOfPax.Name = "lblMinOfPax";
            this.lblMinOfPax.Size = new System.Drawing.Size(80, 20);
            this.lblMinOfPax.TabIndex = 13;
            this.lblMinOfPax.Text = "20 People";
            this.lblMinOfPax.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEventsTitle
            // 
            this.lblEventsTitle.AutoSize = true;
            this.lblEventsTitle.Location = new System.Drawing.Point(353, 10);
            this.lblEventsTitle.Name = "lblEventsTitle";
            this.lblEventsTitle.Size = new System.Drawing.Size(66, 20);
            this.lblEventsTitle.TabIndex = 14;
            this.lblEventsTitle.Text = "Events: ";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(355, 33);
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
            this.lblDescriptions.MaximumSize = new System.Drawing.Size(270, 50);
            this.lblDescriptions.Name = "lblDescriptions";
            this.lblDescriptions.Size = new System.Drawing.Size(270, 50);
            this.lblDescriptions.TabIndex = 16;
            this.lblDescriptions.Text = resources.GetString("lblDescriptions.Text");
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Image = global::IOOP_Assignment.Properties.Resources.addIcon;
            this.addButton.Location = new System.Drawing.Point(-4, -3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(46, 52);
            this.addButton.TabIndex = 17;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(436, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 49);
            this.panel1.TabIndex = 18;
            // 
            // placeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescriptions);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblEventsTitle);
            this.Controls.Add(this.lblMinOfPax);
            this.Controls.Add(this.lblMinOfPaxTitle);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.placeImagePBox);
            this.Name = "placeButton";
            this.Size = new System.Drawing.Size(475, 150);
            ((System.ComponentModel.ISupportInitialize)(this.placeImagePBox)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}
