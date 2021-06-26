using System;
using System.Collections.Generic;
using System.Text;

namespace CampusEntryApplication
{
    public class Guest : Person
    {

        string _appointmentby;
        public Guest(string name, String dob, string mobileno, string appiontmentby, string address) : base(name, dob, mobileno, address)
        {
            this._appointmentby = appiontmentby;
        }
    }
}
