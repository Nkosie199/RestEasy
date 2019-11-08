namespace RestEasyHotelsBookingSystem2015.PresentationLayer
{
    partial class RoomListForm
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
            this.roomsListLabel = new System.Windows.Forms.Label();
            this.roomsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // roomsListLabel
            // 
            this.roomsListLabel.AutoSize = true;
            this.roomsListLabel.BackColor = System.Drawing.Color.White;
            this.roomsListLabel.Location = new System.Drawing.Point(78, 42);
            this.roomsListLabel.Name = "roomsListLabel";
            this.roomsListLabel.Size = new System.Drawing.Size(102, 13);
            this.roomsListLabel.TabIndex = 0;
            this.roomsListLabel.Text = "List of Hotel Rooms:";
            // 
            // roomsListView
            // 
            this.roomsListView.Location = new System.Drawing.Point(81, 99);
            this.roomsListView.Name = "roomsListView";
            this.roomsListView.Size = new System.Drawing.Size(310, 197);
            this.roomsListView.TabIndex = 1;
            this.roomsListView.UseCompatibleStateImageBehavior = false;
            // 
            // RoomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 373);
            this.Controls.Add(this.roomsListView);
            this.Controls.Add(this.roomsListLabel);
            this.Name = "RoomListForm";
            this.Text = "RoomListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomsListLabel;
        private System.Windows.Forms.ListView roomsListView;
    }
}