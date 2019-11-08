using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

//Name Spaces
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using RestEasyHotelsBookingSystem2015.Properties;


namespace RestEasyHotelsBookingSystem2015.DatabaseLayer
{
    class DB
    {
        private string strConn = Settings.Default.GuestsConnectionString;
        protected SqlConnection cnMain;

        //  protected string aSQLstring;

        public DB()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        protected bool UpdateDataSource(SqlCommand currentCommand)
        {
            bool success;
            try
            {
                //open the connection
                cnMain.Open();

                currentCommand.CommandType = CommandType.Text;
                currentCommand.ExecuteNonQuery();

                //close the connection
                cnMain.Close();
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                cnMain.Close();
                success = false;
            }
            finally
            {
            }
            return success;
        }
    }
}
