using System;

namespace DelegateConsoleApp
{
    delegate void DisplayStudent(Student student);
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StudentTable studentTable = new StudentTable();
            studentTable.Display(DisplayCallback);

        }

        static void DisplayCallback(Student student)
        {
            if (student.Sex == "男")
            {
                Console.WriteLine($"学号{student.Number}，姓名：{student.Name}，性别：{student.Sex}");
            }

        }
    }


    class StudentTable
    {
        Student[] students ;
        public StudentTable()
        {
            students = new Student[8];
            students[0] = new Student { Name = "张三", Number = 201201, Sex = "男" };
            students[1] = new Student { Name = "张四", Number = 201201, Sex = "女" };
            students[2] = new Student { Name = "张五", Number = 201201, Sex = "男" };
            students[3] = new Student { Name = "张六", Number = 201201, Sex = "女" };
            students[4] = new Student { Name = "张七", Number = 201201, Sex = "男" };
            students[5] = new Student { Name = "张八", Number = 201201, Sex = "男" };
            students[6] = new Student { Name = "张九", Number = 201201, Sex = "女" };
        }

        public void Display(DisplayStudent displayCallBack)
        {
            foreach (Student student in students)
            {
                displayCallBack(student);
            }
        }
    }

    struct Student
    {
        public int Number;
        public string Name;
        public string Sex;
    }
}
