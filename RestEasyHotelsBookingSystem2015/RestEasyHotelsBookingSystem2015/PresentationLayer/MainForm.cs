using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestEasyHotelsBookingSystem2015.PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
        }

        #region Menu Click Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.EnableEditDeleteMenus(false);
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listAllGuestsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listAllRoomsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makeABooking_Click(object sender, EventArgs e)
        {

        }

        private void changeABooking_Click(object sender, EventArgs e)
        {

        }

        private void cancelABooking_Click(object sender, EventArgs e)
        {

        }

        private void makeBookingEnquiry_Click(object sender, EventArgs e)
        {

        }

        private void generateOccupancyReport_Click(object sender, EventArgs e)
        {

        }

        private void generateBookingDatesReport_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Create Child Forms

        private void CreateNewEmpForm()
        {
            employeeForm = new EmployeeForm(employeeController);
            employeeForm.MdiParent = this;        // Setting the MDI Parent
            employeeForm.StartPosition = FormStartPosition.CenterParent;
        }
        private void CreateNewListForm()
        {
            employeeListForm = new EmployeeListForm(employeeController);
            employeeListForm.MdiParent = this;
            employeeListForm.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        #region Utility Methods
        public void EnableEditDeleteMenus(bool value)
        {
            editAnEmployeeMenuItem.Enabled = value;
            deleteAnEmployeeMenuItem.Enabled = value;
        }

        public void EnableAddMenu(bool value)
        {
            addAnEmployeeMenuItem.Enabled = value;
        }
        #endregion
    }
}
