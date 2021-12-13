using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_1005
{
    abstract class Student
    {
        private String mLastName; // Not accessible to the outside class
        private String mFirstName; // Visible to this class and derived classes

        public String firstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }

        public String lastName
        {
            get { return mLastName; } // This is the way to implement data hiding
            set { mLastName = value;  }
        }
    }
}
