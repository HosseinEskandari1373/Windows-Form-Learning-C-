using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    class Person
    {
        public int _id;
        public string _firstName;
        public string _lastName;

        public string Valid_Person()
        {
            return _firstName + " " + _lastName + " " + _id;
        }
    }
}
