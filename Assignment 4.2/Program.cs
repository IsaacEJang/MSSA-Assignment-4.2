using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }

        internal static List<Student> studentList = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "John Doe", GPA = 3.5 },
            new Student { StudentId = 2, StudentName = "Jane Smith", GPA = 3.8 },
            new Student { StudentId = 3, StudentName = "Alice Johnson", GPA = 3.2 },
            new Student { StudentId = 4, StudentName = "Bob Brown", GPA = 3.6 },
            new Student { StudentId = 5, StudentName = "Charlie Davis", GPA = 3.9 }
        };

    }
}
