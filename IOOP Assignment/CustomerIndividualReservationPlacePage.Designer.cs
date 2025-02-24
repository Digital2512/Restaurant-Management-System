﻿namespace IOOP_Assignment
{
    partial class CustomerIndividualReservationPlacePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerIndividualReservationPlacePage));
            this.headerPnl = new System.Windows.Forms.Panel();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.placeDetailsPnl = new System.Windows.Forms.Panel();
            this.startTimeCBox = new System.Windows.Forms.ComboBox();
            this.lblReservedStartTime = new System.Windows.Forms.Label();
            this.endTimeCBox = new System.Windows.Forms.ComboBox();
            this.lblReservedEndTime = new System.Windows.Forms.Label();
            this.noOfPaxTxtBox = new System.Windows.Forms.TextBox();
            this.lblNoOfPax = new System.Windows.Forms.Label();
            this.lblReservedDate = new System.Windows.Forms.Label();
            this.reservedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblPlaceEventType = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblMinOfPax = new System.Windows.Forms.Label();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.placeImagePBox = new System.Windows.Forms.PictureBox();
            this.specialInstructionsRTxtBox = new System.Windows.Forms.RichTextBox();
            this.lblPlaceID = new System.Windows.Forms.Label();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblPlaceDescription = new System.Windows.Forms.Label();
            this.lblPlaceMinOfPax = new System.Windows.Forms.Label();
            this.headerPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.placeDetailsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeImagePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(573, 45);
            this.headerPnl.TabIndex = 11;
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backBtn);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(-34, -7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 59);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backButton_Click);
            // 
            // placeDetailsPnl
            // 
            this.placeDetailsPnl.AutoScroll = true;
            this.placeDetailsPnl.Controls.Add(this.startTimeCBox);
            this.placeDetailsPnl.Controls.Add(this.lblReservedStartTime);
            this.placeDetailsPnl.Controls.Add(this.endTimeCBox);
            this.placeDetailsPnl.Controls.Add(this.lblReservedEndTime);
            this.placeDetailsPnl.Controls.Add(this.noOfPaxTxtBox);
            this.placeDetailsPnl.Controls.Add(this.lblNoOfPax);
            this.placeDetailsPnl.Controls.Add(this.lblReservedDate);
            this.placeDetailsPnl.Controls.Add(this.reservedDateTimePicker);
            this.placeDetailsPnl.Controls.Add(this.lblPlaceEventType);
            this.placeDetailsPnl.Controls.Add(this.lblEventType);
            this.placeDetailsPnl.Controls.Add(this.lblMinOfPax);
            this.placeDetailsPnl.Controls.Add(this.reserveBtn);
            this.placeDetailsPnl.Controls.Add(this.placeImagePBox);
            this.placeDetailsPnl.Controls.Add(this.specialInstructionsRTxtBox);
            this.placeDetailsPnl.Controls.Add(this.lblPlaceID);
            this.placeDetailsPnl.Controls.Add(this.lblSpecialInstructions);
            this.placeDetailsPnl.Controls.Add(this.lblPlaceName);
            this.placeDetailsPnl.Controls.Add(this.lblPlaceDescription);
            this.placeDetailsPnl.Controls.Add(this.lblPlaceMinOfPax);
            this.placeDetailsPnl.Location = new System.Drawing.Point(-1, 47);
            this.placeDetailsPnl.Name = "placeDetailsPnl";
            this.placeDetailsPnl.Size = new System.Drawing.Size(574, 730);
            this.placeDetailsPnl.TabIndex = 12;
            // 
            // startTimeCBox
            // 
            this.startTimeCBox.FormattingEnabled = true;
            this.startTimeCBox.Items.AddRange(new object[] {
            "17:00 (5:00 PM)",
            "18:00 (6:00 PM)",
            "19:00 (7:00 PM)",
            "20:00 (8:00 PM)",
            "21:00 (9:00 PM)",
            "22:00 (10:00 PM)"});
            this.startTimeCBox.Location = new System.Drawing.Point(24, 669);
            this.startTimeCBox.Name = "startTimeCBox";
            this.startTimeCBox.Size = new System.Drawing.Size(223, 28);
            this.startTimeCBox.TabIndex = 26;
            this.startTimeCBox.SelectedIndexChanged += new System.EventHandler(this.startTimeCBox_SelectedIndexChanged);
            // 
            // lblReservedStartTime
            // 
            this.lblReservedStartTime.AutoSize = true;
            this.lblReservedStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReservedStartTime.Location = new System.Drawing.Point(19, 640);
            this.lblReservedStartTime.Name = "lblReservedStartTime";
            this.lblReservedStartTime.Size = new System.Drawing.Size(196, 25);
            this.lblReservedStartTime.TabIndex = 25;
            this.lblReservedStartTime.Text = "Reserved Start Time:";
            // 
            // endTimeCBox
            // 
            this.endTimeCBox.FormattingEnabled = true;
            this.endTimeCBox.Location = new System.Drawing.Point(292, 669);
            this.endTimeCBox.Name = "endTimeCBox";
            this.endTimeCBox.Size = new System.Drawing.Size(223, 28);
            this.endTimeCBox.TabIndex = 24;
            // 
            // lblReservedEndTime
            // 
            this.lblReservedEndTime.AutoSize = true;
            this.lblReservedEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReservedEndTime.Location = new System.Drawing.Point(288, 639);
            this.lblReservedEndTime.Name = "lblReservedEndTime";
            this.lblReservedEndTime.Size = new System.Drawing.Size(184, 25);
            this.lblReservedEndTime.TabIndex = 23;
            this.lblReservedEndTime.Text = "Reserved End Time";
            // 
            // noOfPaxTxtBox
            // 
            this.noOfPaxTxtBox.Location = new System.Drawing.Point(292, 601);
            this.noOfPaxTxtBox.Name = "noOfPaxTxtBox";
            this.noOfPaxTxtBox.Size = new System.Drawing.Size(223, 26);
            this.noOfPaxTxtBox.TabIndex = 22;
            // 
            // lblNoOfPax
            // 
            this.lblNoOfPax.AutoSize = true;
            this.lblNoOfPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoOfPax.Location = new System.Drawing.Point(288, 569);
            this.lblNoOfPax.Name = "lblNoOfPax";
            this.lblNoOfPax.Size = new System.Drawing.Size(157, 25);
            this.lblNoOfPax.TabIndex = 21;
            this.lblNoOfPax.Text = "Number Of Pax: ";
            // 
            // lblReservedDate
            // 
            this.lblReservedDate.AutoSize = true;
            this.lblReservedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReservedDate.Location = new System.Drawing.Point(19, 569);
            this.lblReservedDate.Name = "lblReservedDate";
            this.lblReservedDate.Size = new System.Drawing.Size(157, 25);
            this.lblReservedDate.TabIndex = 20;
            this.lblReservedDate.Text = "Reserved Date:  ";
            // 
            // reservedDateTimePicker
            // 
            this.reservedDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.reservedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reservedDateTimePicker.Location = new System.Drawing.Point(24, 599);
            this.reservedDateTimePicker.Name = "reservedDateTimePicker";
            this.reservedDateTimePicker.Size = new System.Drawing.Size(234, 26);
            this.reservedDateTimePicker.TabIndex = 19;
            this.reservedDateTimePicker.ValueChanged += new System.EventHandler(this.reservedDateTimePicker_ValueChanged);
            // 
            // lblPlaceEventType
            // 
            this.lblPlaceEventType.AutoSize = true;
            this.lblPlaceEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPlaceEventType.Location = new System.Drawing.Point(426, 375);
            this.lblPlaceEventType.MaximumSize = new System.Drawing.Size(140, 60);
            this.lblPlaceEventType.Name = "lblPlaceEventType";
            this.lblPlaceEventType.Size = new System.Drawing.Size(132, 60);
            this.lblPlaceEventType.TabIndex = 18;
            this.lblPlaceEventType.Text = "Birthday, Gathering, Party, Birthday, Gathering, Party";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEventType.Location = new System.Drawing.Point(423, 345);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(118, 25);
            this.lblEventType.TabIndex = 17;
            this.lblEventType.Text = "Event Type:";
            this.lblEventType.Click += new System.EventHandler(this.lblEventType_Click);
            // 
            // lblMinOfPax
            // 
            this.lblMinOfPax.AutoSize = true;
            this.lblMinOfPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMinOfPax.Location = new System.Drawing.Point(288, 345);
            this.lblMinOfPax.Name = "lblMinOfPax";
            this.lblMinOfPax.Size = new System.Drawing.Size(110, 25);
            this.lblMinOfPax.TabIndex = 16;
            this.lblMinOfPax.Text = "Min of Pax:";
            // 
            // reserveBtn
            // 
            this.reserveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBtn.Location = new System.Drawing.Point(3, 830);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(593, 53);
            this.reserveBtn.TabIndex = 15;
            this.reserveBtn.Text = "RESERVE";
            this.reserveBtn.UseVisualStyleBackColor = true;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // placeImagePBox
            // 
            this.placeImagePBox.Image = global::IOOP_Assignment.Properties.Resources.errorImage;
            this.placeImagePBox.Location = new System.Drawing.Point(0, 0);
            this.placeImagePBox.Name = "placeImagePBox";
            this.placeImagePBox.Size = new System.Drawing.Size(574, 334);
            this.placeImagePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.placeImagePBox.TabIndex = 14;
            this.placeImagePBox.TabStop = false;
            // 
            // specialInstructionsRTxtBox
            // 
            this.specialInstructionsRTxtBox.Location = new System.Drawing.Point(20, 735);
            this.specialInstructionsRTxtBox.Name = "specialInstructionsRTxtBox";
            this.specialInstructionsRTxtBox.Size = new System.Drawing.Size(548, 91);
            this.specialInstructionsRTxtBox.TabIndex = 13;
            this.specialInstructionsRTxtBox.Text = "";
            // 
            // lblPlaceID
            // 
            this.lblPlaceID.AutoSize = true;
            this.lblPlaceID.Location = new System.Drawing.Point(16, 345);
            this.lblPlaceID.Name = "lblPlaceID";
            this.lblPlaceID.Size = new System.Drawing.Size(77, 20);
            this.lblPlaceID.TabIndex = 8;
            this.lblPlaceID.Text = "HALL001";
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpecialInstructions.Location = new System.Drawing.Point(17, 703);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(192, 25);
            this.lblSpecialInstructions.TabIndex = 12;
            this.lblSpecialInstructions.Text = "Special Instructions: ";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPlaceName.Location = new System.Drawing.Point(16, 368);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(74, 29);
            this.lblPlaceName.TabIndex = 9;
            this.lblPlaceName.Text = "Hall 1";
            // 
            // lblPlaceDescription
            // 
            this.lblPlaceDescription.AutoSize = true;
            this.lblPlaceDescription.Location = new System.Drawing.Point(16, 473);
            this.lblPlaceDescription.MaximumSize = new System.Drawing.Size(550, 80);
            this.lblPlaceDescription.Name = "lblPlaceDescription";
            this.lblPlaceDescription.Size = new System.Drawing.Size(539, 80);
            this.lblPlaceDescription.TabIndex = 11;
            this.lblPlaceDescription.Text = resources.GetString("lblPlaceDescription.Text");
            // 
            // lblPlaceMinOfPax
            // 
            this.lblPlaceMinOfPax.AutoSize = true;
            this.lblPlaceMinOfPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPlaceMinOfPax.Location = new System.Drawing.Point(292, 376);
            this.lblPlaceMinOfPax.Name = "lblPlaceMinOfPax";
            this.lblPlaceMinOfPax.Size = new System.Drawing.Size(80, 20);
            this.lblPlaceMinOfPax.TabIndex = 10;
            this.lblPlaceMinOfPax.Text = "20 People";
            // 
            // CustomerIndividualReservationPlacePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 775);
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.placeDetailsPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerIndividualReservationPlacePage";
            this.Text = "CustomerIndividualReservationPlacePage";
            this.headerPnl.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.placeDetailsPnl.ResumeLayout(false);
            this.placeDetailsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeImagePBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel placeDetailsPnl;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.PictureBox placeImagePBox;
        private System.Windows.Forms.RichTextBox specialInstructionsRTxtBox;
        private System.Windows.Forms.Label lblPlaceID;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblPlaceDescription;
        private System.Windows.Forms.Label lblPlaceMinOfPax;
        private System.Windows.Forms.Label lblPlaceEventType;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblMinOfPax;
        private System.Windows.Forms.Label lblReservedDate;
        private System.Windows.Forms.DateTimePicker reservedDateTimePicker;
        private System.Windows.Forms.TextBox noOfPaxTxtBox;
        private System.Windows.Forms.Label lblNoOfPax;
        private System.Windows.Forms.ComboBox endTimeCBox;
        private System.Windows.Forms.Label lblReservedEndTime;
        private System.Windows.Forms.ComboBox startTimeCBox;
        private System.Windows.Forms.Label lblReservedStartTime;
    }
}