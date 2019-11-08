using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using RestEasyHotelsBookingSystem2015.DatabaseLayer;

namespace RestEasyHotelsBookingSystem2015.Guests
{
    class GuestsController
    {
        private GuestDB guestDB;
        private Collection<Guests> guests;

        public GuestsController()
        {
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }

        public Collection<Guests> AllGuests
        {
            get
            {
                return guests;
            }
        }

        #region CRUD functionality - Maintain Collection and Database
        public void ADD(Employee employee)
        {
            //Write code to add employee. Remember to use the DatabaseADD method from the EmployeeDB class
            employeeDB.DatabaseAdd(employee);
            //Also add the employee to the employees collection?
            employees.Add(employee);
        }

        public void Edit(Employee employee)
        {
            int index;
            // edit the entry in the collection - // A GOOD examples of Polymorphism
            index = FindIndex(employee);
            employees.RemoveAt(index);
            employees[index] = employee;
            //An alternative will be to remove the old employee 
            //out of the list and replace with the new employee using the ID            
            //Employee tempEmployee;
            //tempEmployee = FindByID(employee.ID);
            //employees.Remove(tempEmployee);     //remove the old employee
            //employees.Add(employee);            // add the edited employee

            //Write code to edit an employee in the database. Remember to use the DatabaseEdit method from the EmployeeDB class
            employeeDB.DatabaseEdit(employee);
        }

        public bool Delete(Employee employee)
        {
            bool success = false;
            int position = 0;
            //Find the entry in the Collection & remove 
            position = FindIndex(employee);
            if (position >= 0)
            {
                employees.RemoveAt(position);
            }
            //remove the entry 
            success = employeeDB.DatabaseDelete(employee);
            return success;
        }

        #endregion

        #region Lookups
        public Collection<Employee> FindByRole(Role.RoleType aRole)
        {
            Collection<Employee> matches = new Collection<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.Role.roleDescription == aRole)
                {
                    matches.Add(employee);
                }
            }
            return matches;
        }

        public int FindIndex(Employee employee)
        {
            int index = 0;
            bool found = false;
            while (!found && index < employees.Count)
            {
                found = (employees[index].ID == employee.ID);
                if (!found)
                {
                    index++;
                }
            }
            if (found)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        public int FindIndex(Collection<Employee> emps, Employee employee)
        {
            int index = 0;
            bool found = false;
            while (!found && index < emps.Count)
            {
                found = (emps[index].ID == employee.ID);
                if (!found)
                {
                    index++;
                }
            }
            if (found)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
        public Employee FindByID(string idValue)
        {
            int position = 0;
            bool found = (idValue == employees[position].ID);
            while (!found && position < employees.Count)
            {
                found = (idValue == employees[position].ID);
                if (!found)
                {
                    position += 1;
                }
            }
            if (found)
            {
                return employees[position];
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
