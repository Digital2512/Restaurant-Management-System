namespace IOOP_Assignment
{
    partial class ManagerAddPlace
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
            this.picPlace = new System.Windows.Forms.PictureBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPlaceID = new System.Windows.Forms.Label();
            this.lblProDesc = new System.Windows.Forms.Label();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtPlaceID = new System.Windows.Forms.TextBox();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.eventTypeCBox = new System.Windows.Forms.ComboBox();
            this.txtEventType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlace
            // 
            this.picPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlace.Location = new System.Drawing.Point(44, 130);
            this.picPlace.Name = "picPlace";
            this.picPlace.Size = new System.Drawing.Size(140, 140);
            this.picPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlace.TabIndex = 36;
            this.picPlace.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(309, 113);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(167, 26);
            this.txtDesc.TabIndex = 37;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(331, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 38);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPlaceID
            // 
            this.lblPlaceID.AutoSize = true;
            this.lblPlaceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceID.Location = new System.Drawing.Point(226, 81);
            this.lblPlaceID.Name = "lblPlaceID";
            this.lblPlaceID.Size = new System.Drawing.Size(77, 22);
            this.lblPlaceID.TabIndex = 29;
            this.lblPlaceID.Text = "PlaceID:";
            // 
            // lblProDesc
            // 
            this.lblProDesc.AutoSize = true;
            this.lblProDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProDesc.Location = new System.Drawing.Point(198, 113);
            this.lblProDesc.Name = "lblProDesc";
            this.lblProDesc.Size = new System.Drawing.Size(105, 22);
            this.lblProDesc.TabIndex = 28;
            this.lblProDesc.Text = "Description:";
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(309, 154);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(167, 26);
            this.txtPlaceName.TabIndex = 27;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(241, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Location = new System.Drawing.Point(71, 276);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 38);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtPlaceID
            // 
            this.txtPlaceID.Location = new System.Drawing.Point(309, 81);
            this.txtPlaceID.Name = "txtPlaceID";
            this.txtPlaceID.Size = new System.Drawing.Size(117, 26);
            this.txtPlaceID.TabIndex = 39;
            // 
            // txtPax
            // 
            this.txtPax.Location = new System.Drawing.Point(309, 195);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(117, 26);
            this.txtPax.TabIndex = 41;
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPax.Location = new System.Drawing.Point(210, 199);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(93, 22);
            this.lblPax.TabIndex = 40;
            this.lblPax.Text = "MinOfPax:";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventType.Location = new System.Drawing.Point(201, 227);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(102, 22);
            this.lblEventType.TabIndex = 42;
            this.lblEventType.Text = "EventType:";
            // 
            // eventTypeCBox
            // 
            this.eventTypeCBox.FormattingEnabled = true;
            this.eventTypeCBox.Items.AddRange(new object[] {
            "Birthday",
            "Gathering",
            "Wedding Party",
            "Corporate Party",
            "Dining",
            "Private Dining"});
            this.eventTypeCBox.Location = new System.Drawing.Point(468, 224);
            this.eventTypeCBox.Name = "eventTypeCBox";
            this.eventTypeCBox.Size = new System.Drawing.Size(121, 28);
            this.eventTypeCBox.TabIndex = 44;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(309, 227);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(117, 26);
            this.txtEventType.TabIndex = 43;
            // 
            // ManagerAddPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventTypeCBox);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.txtPlaceID);
            this.Controls.Add(this.picPlace);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPlaceID);
            this.Controls.Add(this.lblProDesc);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpload);
            this.Name = "ManagerAddPlace";
            this.Text = "AddPlace";
            ((System.ComponentModel.ISupportInitialize)(this.picPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlace;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPlaceID;
        private System.Windows.Forms.Label lblProDesc;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtPlaceID;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.ComboBox eventTypeCBox;
        private System.Windows.Forms.TextBox txtEventType;
    }
}