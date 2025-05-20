namespace StudentSpace
{
    public class SchoolReport
    {
        public void GenerateReportCard(Student student)
        {
            string name = student.Name;
            int age = student.Age;
            Console.WriteLine($"\n[Student]:\nName: {name}\nAge : {age}\nAverage: {student.GetAverageGrade()}");
            student.ListGrades();
        }

        public void GenerateOverallReport(School school)
        {
            foreach (var student in school.StudentList)
            {
                GenerateReportCard(student);
            }
        }
    }
}