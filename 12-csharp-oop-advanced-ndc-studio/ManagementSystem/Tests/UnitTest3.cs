namespace Tests;

using Xunit;
using ManagementSystem;
using System;

public class UnitTest3
{
    [Fact]
    public void Test_AddProject_ResturnString()
    {
        var taskManager = new TaskManager();
        var project = new Project("Porte Folio");
        var task = new Task("Update homepage", "Redesign CSS Presentation Page 2", "Stephan", DateTime.Now.AddDays(-2), PriorityLevel.High);

        project.AddTask(task);
        var result = taskManager.AddProject(project);

        Assert.Equal($"The project named Porte Folio has been added successfully.", result);
    }

    [Fact]
    public void GetTasksByAssignedUser_ShouldDisplayTasksOfUser()
    {
        var taskManager = new TaskManager();
        var project = new Project("Test Project");
        var task = new Task("Fix bug", "Fix login issue", "Alice", DateTime.Now.AddDays(1), PriorityLevel.High);
        project.AddTask(task);
        taskManager.AddProject(project);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        taskManager.GetTasksByAssignedUser("Alice");

        var output = sw.ToString();
        Assert.Contains("Fix bug", output);
    }

    [Fact]
    public void ListAllOverdueTasks_ShouldPrintOnlyOverdueTasks()
    {
        var taskManager = new TaskManager();
        var project = new Project("Test Project");

        var overdueTask = new Task("Late Task", "Was due", "Bob", DateTime.Now.AddDays(-3), PriorityLevel.Low);
        var futureTask = new Task("Future Task", "Not yet due", "Bob", DateTime.Now.AddDays(3), PriorityLevel.Low);

        project.AddTask(overdueTask);
        project.AddTask(futureTask);
        taskManager.AddProject(project);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        taskManager.ListAllOverdueTasks();

        var output = sw.ToString();
        Assert.Contains("Late Task", output);
        Assert.DoesNotContain("Future Task", output);
    }

    [Fact]
    public void ListAllTasksByPriority_ShouldDisplayOnlySelectedPriorityTasks()
    {
        var taskManager = new TaskManager();
        var project = new Project("Test Project");

        var task1 = new Task("Urgent", "desc", "Charlie", DateTime.Now, PriorityLevel.High);
        var task2 = new Task("Normal", "desc", "Charlie", DateTime.Now, PriorityLevel.Low);

        project.AddTask(task1);
        project.AddTask(task2);
        taskManager.AddProject(project);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        taskManager.ListAllTasksByPriority(PriorityLevel.High);

        var output = sw.ToString();
        Assert.Contains("Urgent", output);
        Assert.DoesNotContain("Normal", output);
    }

    [Fact]
    public void ListTasksByProject_ShouldDisplayAllTasksOfGivenProject()
    {
        var taskManager = new TaskManager();
        var project = new Project("MyApp");

        var task = new Task("Feature A", "desc", "Eve", DateTime.Now, PriorityLevel.Medium);
        project.AddTask(task);
        taskManager.AddProject(project);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        taskManager.ListTasksByProject("MyApp");

        var output = sw.ToString();
        Assert.Contains("Feature A", output);
    }

    [Fact]
    public void ListTasksByProject_ShouldPrintMessageIfProjectNotFound()
    {
        var taskManager = new TaskManager();

        using var sw = new StringWriter();
        Console.SetOut(sw);

        taskManager.ListTasksByProject("NonExistent");

        var output = sw.ToString();
        Assert.Contains("No project founded with the name: NonExistent", output);
    }

    [Fact]
    public void GenerateReport_ShouldPrintCorrectTaskStats()
    {
        var taskManager = new TaskManager();
        var project = new Project("ReportTest");

        var task1 = new Task("Done", "desc", "Ana", DateTime.Now.AddDays(-1), PriorityLevel.High);
        var task2 = new Task("Late", "desc", "Ana", DateTime.Now.AddDays(-3), PriorityLevel.High);
        task1.CompleteTask();

        project.AddTask(task1);
        project.AddTask(task2);
        taskManager.AddProject(project);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        taskManager.GenerateReport();

        var output = sw.ToString();
        Assert.Contains("Projet : ReportTest", output);
        Assert.Contains("- Total of tasks    : 2", output);
        Assert.Contains("- Completed tasks  : 1", output);
        Assert.Contains("- Overdue tasks   : 1", output);
    }

}
