using StudentTester.Entities;
using StudentTester.Services;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet tuSE = new Cabinet(500);
            Cabinet tuIA = new Cabinet(100);

            tuSE.AddStudent("SE181532", "Thanh Bình", 2004, 8.6);
            tuSE.AddStudent("SE180672", "Việt Nguyễn", 2004, 8.3);
            tuSE.AddStudent(new Student() { Id = "DE181532", Name = "Binhdaynee", Yob = 2004, Gpa = 8.7} );

            //tuIA.AddStudent("SE1", "Student IA1", 2004, 8.386);

            //Console.WriteLine("The List of IA Students: ");
            //tuIA.PrintStudentList();

            //Console.WriteLine("The List of SE Students: ");
            //tuSE.PrintStudentList();

            //tuSE.UpdateStudent("DE181532", "Binhidolne", null, null);

            //Console.WriteLine("After updating DE181532'S Name: ");
            //tuSE.PrintStudentList();
            tuSE.DeleteStudent("SE180672");
            tuSE.PrintStudentList();
            tuSE.UpdateStudent("SE181532", null, 2005, null);
            tuSE.PrintStudentList();
        }
    }
}
