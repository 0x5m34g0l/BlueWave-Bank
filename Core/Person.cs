using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlueWave_Bank
{
    internal class Person
    {
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private string _Phone;

        public Person(string FirstName, string LastName, string Email, string Phone) 
        {
            _FirstName = FirstName;
            _LastName = LastName;
            _Email = Email;
            _Phone = Phone;
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string FullName()
        {
            return _FirstName + " " + _LastName;
        }
    }
}
