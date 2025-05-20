namespace StudentSpace
{
    class Program
    {
        public static void Main(String[] args)
        {
            var school = new School();
            SchoolReport report = new();

            var student = new Student("Jhoe", 16);
            var student1 = new Student("Maxime", 17);
            var student2 = new Student("Camille", 15);
            var student3 = new Student("Mikey", 18);
            var student4 = new Student("Julien", 16);

            student.AddGrade("History", 10);
            student.AddGrade("Math", 10);
            student.AddGrade("Philo", 10);
            student.AddGrade("Science", 10);
            student.AddGrade("Science", 10);
            student.AddGrade("Sport", 10);

            student1.AddGrade("History", 10);
            student1.AddGrade("Math", 10);
            student1.AddGrade("Math", 10);
            student1.AddGrade("English", 10);
            student1.AddGrade("Science", 10);
            student1.AddGrade("Sport", 10);

            student2.AddGrade("History", 10);
            student2.AddGrade("Math", 10);
            student2.AddGrade("Philo", 10);
            student2.AddGrade("English", 10);
            student2.AddGrade("Philo", 10);
            student2.AddGrade("Sport", 10);

            student3.AddGrade("History", 10);
            student3.AddGrade("Math", 10);
            student3.AddGrade("Philo", 10);
            student3.AddGrade("English", 10);
            student3.AddGrade("Science", 10);
            student3.AddGrade("Math", 10);
                    
            student4.AddGrade("History", 10);
            student4.AddGrade("Math", 10);
            student4.AddGrade("Philo", 10);
            student4.AddGrade("Philo", 10);
            student4.AddGrade("Philo", 10);
            student4.AddGrade("Sport", 10);

            school.AddStudent(student);
            school.AddStudent(student1);
            school.AddStudent(student2);
            school.AddStudent(student3);
            school.AddStudent(student4);

            school.ListStudents();
            var foundedStudent = school.FindStudent("Maxime");
            report.GenerateReportCard(foundedStudent);

            Console.WriteLine("\n-----------------------------");

            report.GenerateOverallReport(school);

            Console.WriteLine("\n-----------------------------\n");

            school.ListTopStudents(3);

            Console.WriteLine("\n\nPress any key for exiting..!");
            Console.ReadKey();
        }
    }
}
