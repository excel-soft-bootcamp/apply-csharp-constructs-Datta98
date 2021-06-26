using System;
using System.Collections.Generic;
using System.Text;

namespace CampusEntryApplication
{
   public abstract class Person
    {
        
        private string _name, _dob, _mobileno, _address;
        public Person(string name)
        {
            this._name = name;
        }
        public Person(string name, string dob) : this(name)
        {
            this._dob = dob;
        }
        public Person(string name, string dob, string mobileno) : this(name, dob)
        {
            this._mobileno = mobileno;
        }
        public Person(string name, string dob, string mobileno, string address) : this(name, dob, mobileno)
        {
            this._address = address;
        }
    }
}
