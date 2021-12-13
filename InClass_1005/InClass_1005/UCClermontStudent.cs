using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_1005
{
    class UCClermontStudent : Student
    {
        private String mMajor;

        public UCClermontStudent()
        {
            firstName = "Unknown"; //can be done because firstName is protected, violation of data hiding
        }

        public String major
        {
            get { return mMajor; }
            set { mMajor = value; }
        }
    }
}
