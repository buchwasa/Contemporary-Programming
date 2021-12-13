using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            UCClermontStudent me = new UCClermontStudent();
            me.lastName = "Cheaney";

            Student student = new UCClermontStudent(); // A derived class object can be assigned to its base class object
            student.lastName = "Bailey";
            Console.WriteLine(student.lastName);

            // Store 4000 students, can use list, array, or arraylist
            List<UCClermontStudent> students = new List<UCClermontStudent>();
            // Empty list, let's fill it
            for (int i = 0; i < 4000; i++)
            {
                students.Add(new UCClermontStudent()); // Instantiate and store the reference in the List
            }

            Console.WriteLine(students.Count);
        }
    }
}
