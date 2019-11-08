namespace RestEasyHotelsBookingSystem2015.PresentationLayer
{
    partial class BookingForm
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
            this.guestName = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.roomID = new System.Windows.Forms.Label();
            this.depositPaid = new System.Windows.Forms.Label();
            this.referenceNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.guestNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.roomIDComboBox = new System.Windows.Forms.ComboBox();
            this.depositPaidCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guestName
            // 
            this.guestName.AutoSize = true;
            this.guestName.Location = new System.Drawing.Point(44, 30);
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(69, 13);
            this.guestName.TabIndex = 0;
            this.guestName.Text = "Guest Name:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(44, 89);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(48, 13);
            this.address.TabIndex = 1;
            this.address.Text = "Address:";
            // 
            // roomID
            // 
            this.roomID.AutoSize = true;
            this.roomID.Location = new System.Drawing.Point(45, 149);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(52, 13);
            this.roomID.TabIndex = 2;
            this.roomID.Text = "Room ID:";
            // 
            // depositPaid
            // 
            this.depositPaid.AutoSize = true;
            this.depositPaid.Location = new System.Drawing.Point(44, 210);
            this.depositPaid.Name = "depositPaid";
            this.depositPaid.Size = new System.Drawing.Size(70, 13);
            this.depositPaid.TabIndex = 3;
            this.depositPaid.Text = "Deposit Paid:";
            // 
            // referenceNumber
            // 
            this.referenceNumber.AutoSize = true;
            this.referenceNumber.Location = new System.Drawing.Point(45, 266);
            this.referenceNumber.Name = "referenceNumber";
            this.referenceNumber.Size = new System.Drawing.Size(100, 13);
            this.referenceNumber.TabIndex = 4;
            this.referenceNumber.Text = "Reference Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Booking Date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(327, 61);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // guestNameTextBox
            // 
            this.guestNameTextBox.Location = new System.Drawing.Point(120, 30);
            this.guestNameTextBox.Name = "guestNameTextBox";
            this.guestNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestNameTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(120, 89);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // roomIDComboBox
            // 
            this.roomIDComboBox.FormattingEnabled = true;
            this.roomIDComboBox.Location = new System.Drawing.Point(120, 140);
            this.roomIDComboBox.Name = "roomIDComboBox";
            this.roomIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.roomIDComboBox.TabIndex = 9;
            // 
            // depositPaidCheckBox
            // 
            this.depositPaidCheckBox.AutoSize = true;
            this.depositPaidCheckBox.Location = new System.Drawing.Point(130, 210);
            this.depositPaidCheckBox.Name = "depositPaidCheckBox";
            this.depositPaidCheckBox.Size = new System.Drawing.Size(15, 14);
            this.depositPaidCheckBox.TabIndex = 10;
            this.depositPaidCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 374);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.depositPaidCheckBox);
            this.Controls.Add(this.roomIDComboBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.guestNameTextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.referenceNumber);
            this.Controls.Add(this.depositPaid);
            this.Controls.Add(this.roomID);
            this.Controls.Add(this.address);
            this.Controls.Add(this.guestName);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guestName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label roomID;
        private System.Windows.Forms.Label depositPaid;
        private System.Windows.Forms.Label referenceNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox guestNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox roomIDComboBox;
        private System.Windows.Forms.CheckBox depositPaidCheckBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}