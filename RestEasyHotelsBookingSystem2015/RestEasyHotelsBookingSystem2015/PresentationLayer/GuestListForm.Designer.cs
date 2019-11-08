namespace RestEasyHotelsBookingSystem2015.PresentationLayer
{
    partial class GuestListForm
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
            this.guestListView = new System.Windows.Forms.ListView();
            this.guestListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guestListView
            // 
            this.guestListView.Location = new System.Drawing.Point(87, 86);
            this.guestListView.Name = "guestListView";
            this.guestListView.Size = new System.Drawing.Size(345, 171);
            this.guestListView.TabIndex = 0;
            this.guestListView.UseCompatibleStateImageBehavior = false;
            // 
            // guestListLabel
            // 
            this.guestListLabel.AutoSize = true;
            this.guestListLabel.BackColor = System.Drawing.Color.White;
            this.guestListLabel.Location = new System.Drawing.Point(84, 31);
            this.guestListLabel.Name = "guestListLabel";
            this.guestListLabel.Size = new System.Drawing.Size(102, 13);
            this.guestListLabel.TabIndex = 1;
            this.guestListLabel.Text = "List of Hotel Guests:";
            // 
            // GuestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 380);
            this.Controls.Add(this.guestListLabel);
            this.Controls.Add(this.guestListView);
            this.Name = "GuestListForm";
            this.Text = "GuestListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView guestListView;
        private System.Windows.Forms.Label guestListLabel;
    }
}