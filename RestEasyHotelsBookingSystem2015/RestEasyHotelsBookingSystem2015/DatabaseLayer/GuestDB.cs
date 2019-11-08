using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

//namespaces
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using RestEasyHotelsBookingSystem2015.Guests;

namespace RestEasyHotelsBookingSystem2015.DatabaseLayer
{
    class GuestDB : DB
    {
        //Data members
        private static string table1 = "Guests";

        private string sql_SELECT1 = "SELECT * FROM " + table1;

        private Collection<Guests> guests = new Collection<Guests>();

        //Constructors
        public GuestDB()
            : base()
        {
            ReadDataFromTable(sql_SELECT1, table1);   //Get the data from ALL 3 tables
        }

        public Collection<Guests> AllGuests
        {
            get
            {
                return guests;
            }
        }

        #region Data reader
        private string ReadDataFromTable(string selectString, string table)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand(selectString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    // Call the FillEmployeeByRole method see step 2.4
                    FillEmployeesByRole(reader, table, employees);       //Fill the collection – 
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return "success";
            }
            catch (Exception ex)
            {
                cnMain.Close();  
                return (ex.ToString());

            }
        }

        private void FillGuests(SqlDataReader reader, string dataTable, Collection<Guests> guests)
        {
            Employee employee;

            while (reader.Read())                          //While you still have stuff to read
            {
                employee = new Employee((byte)employeeRole);
                //Same for EmpID, Name  & Phone, all strings with indices 1, 2, & 3 respectively
                employee.ID = reader.GetString(0).Trim();
                employee.EmpID = reader.GetString(1).Trim();
                employee.Name = reader.GetString(2).Trim();
                employee.Phone = reader.GetString(3).Trim();
                //call the GetRoleInfo method to obtain role specific data from the database
                employee.Role = GetRoleInfo(reader, employee);
                employees.Add(employee);             //add to the collection
            }
        }
        #endregion

        #region Database Operations --- Add, Edit & Delete
        public void DatabaseAdd(Guest tempGuest)
        {
            string strSQL = "";

            //Build SQL string for the command
            strSQL = "INSERT into Guests(BookingID, GuestName, Address, BookingDate, RoomID, ReferenceNumber, PhoneNumber, DepositPaid)" +
                         "VALUES ('" + GetValueString(tempGuest) + ")";

            //Create & execute the insert command 
            UpdateDataSource(new SqlCommand(strSQL, cnMain));
        }


        public void DatabaseEdit(Guest tempGuest)
        {
            string sqlString = "";
            //Build SQL string for the Update command
            sqlString = "Update Guests Set Name = '" + tempEmp.Name.Trim() + "'," +
                              "Phone = '" + tempEmp.Phone.Trim() + "'," +
                              "Salary =" + headWaitron.Salary.ToString() + " " +
                              "WHERE (ID = '" + tempEmp.ID.Trim() + "')";
           
            //Create & execute the update command 
            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }

        public bool DatabaseDelete(Guest tempGuest)
        {
            string SQLstring = "";
            bool success = false;
            //Build SQL string for the DELETE command
            SQLstring = "DELETE FROM  HeadWaitron WHERE ID = '" + employee.ID + "'";
            
            //Update database by executing new SQL statement--customer table
            success = UpdateDataSource(new SqlCommand(SQLstring, cnMain));
            return true;
        }

        private string GetValueString(Guest tempGuest)
        {
            string aStr;
            decimal pay = 0;
            string additional ="";

            aStr = TempEmp.ID + "' , '" + TempEmp.EmpID + "' ," +
                  "'" + TempEmp.Name + "' ," +
                  " '" + (TempEmp.Phone).Trim() + "' , " +
                                   Convert.ToString(pay) + additional;

            return aStr;
        }

        #endregion
    }
}
