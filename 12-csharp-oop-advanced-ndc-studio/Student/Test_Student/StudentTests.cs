namespace Tests;

using Xunit;
using StudentSpace;

public class StudentTests
{
    [Fact]
    public void Student_Should_Be_Added_To_School_List()
    {
        var school = new School();
        var student = new Student("Jhoe", 16);

        school.AddStudent(student);

        var found = school.FindStudent("Jhoe");

        Assert.NotNull(found);
        Assert.Equal("Jhoe", found.Name);
    }

    [Fact]
    public void AddGrade_CreateNewGrade_IfNotExist()
    {
        var student = new Student("Alice", 16);

        student.AddGrade("Math", 10);

        Assert.Single(student.Grades);
        Assert.Equal("Math", student.Grades[0].Subject);
        Assert.Equal(10, student.Grades[0].Score);
    }

    [Fact]
    public void AddGrade_IncrementTheScore_IfAlreadyExists()
    {
        var student = new Student("Alice", 16);

        student.AddGrade("Math", 10);
        student.AddGrade("Math", 5);

        Assert.Single(student.Grades);
        Assert.Equal(15, student.Grades[0].Score);
    }

    [Fact]
    public void GetAverageGrade_ReturnCorrectAverage()
    {
        var student = new Student("Alice", 16);

        student.AddGrade("Math", 10);
        student.AddGrade("Science", 20);

        var average = student.GetAverageGrade();

        Assert.Equal(15, average);
    }

    [Fact]
    public void AddStudent_AddNewStudent_IfNotInTheList()
    {
        var school = new School();
        var student = new Student("Luna", 17);

        school.AddStudent(student);

        Assert.Single(school.StudentList);
        Assert.Equal("Luna", school.StudentList[0].Name);
    }

    [Fact]
    public void AddStudent_NotAddStudent_IfHisNameAlreadyExists()
    {
        var school = new School();
        var student = new Student("Luna", 17);

        school.AddStudent(student);
        school.AddStudent(student);

        Assert.Single(school.StudentList);
    }

    [Fact]
    public void FindStudent_ReturnStudent_IfNameExists()
    {
        var school = new School();
        var student = new Student("Leo", 18);
        school.AddStudent(student);

        var found = school.FindStudent("Leo");

        Assert.NotNull(found);
        Assert.Equal("Leo", found.Name);
    }

    [Fact]
    public void FindStudent_ReturnNull_IfNameNotExist()
    {
        var school = new School();

        var result = school.FindStudent("Chloe");

        Assert.Null(result);
    }
}
