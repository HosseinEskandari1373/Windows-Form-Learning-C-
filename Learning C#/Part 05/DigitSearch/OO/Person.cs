using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    class Person
    {
        public Person()
        {
            _id = -1;
            //_firstName = "مقداردهی نشده";
            //_lastName = "مقداردهی نشده";
        }
        public Person(int pid)
        {
            pid = _id;
        }
        public Person(string pFirstName)
        {
            FirstName = pFirstName;
        }

        private int _id;
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 10000 || value > 100000)
                {
                    _id = 0;
                }
                else
                {
                    _id = value;
                }
            }
        }

        //public string _firstName;
        //public string _lastName;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        //public string Valid_Person()
        //{
        //    return _firstName + " " + _lastName + " " + _id;
        //}
    }
}
