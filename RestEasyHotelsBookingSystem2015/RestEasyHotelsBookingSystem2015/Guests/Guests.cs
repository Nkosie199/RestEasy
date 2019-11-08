using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestEasyHotelsBookingSystem2015.Guests
{
    class Guests
    {
        #region Data members
        //An employee has ALL the attributes of a person AND 
        //he/she also has an Employee number and a ROLE object
        private string guestID;
        #endregion

        #region Properties
        public string GuestID
        {
            get
            {
                return guestID;
            }
            set
            {
                guestID = value;
            }
        }

        #region Constructors
        //Employee will always be created in a specific role -- IF NO role is assigned  
        //Role will just be the empty object i.e. "Nothing"

        public Employee(byte roleValue)
        {
            
        }
        #endregion

        public override string ToString()
        {
            return this.empID + ":    " + this.Name;
        }
    }
}
