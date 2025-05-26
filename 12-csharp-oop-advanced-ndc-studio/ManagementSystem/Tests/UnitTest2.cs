namespace Tests;

using Xunit;
using ManagementSystem;
using System;

public class UnitTest2
{
    [Fact]
    public void AddTask_Should_AddTaskToList()
    {
        var project = new Project("Test Project");
        var task = new Task("Task 1", "Description", "Alice", DateTime.Now.AddDays(1), PriorityLevel.Medium);

        project.AddTask(task);

        Assert.Single(project.TaskList);
        Assert.Equal("Task 1", project.TaskList[0].Title);
    }
    [Fact]
    public void GetOverdueTasks_Should_ReturnOnlyOverdueTasks()
    {
        var project = new Project("Test Project");

        var task1 = new Task("Old Task", "Past due", "Alice", DateTime.Now.AddDays(-2), PriorityLevel.High);
        var task2 = new Task("Future Task", "Not due yet", "Bob", DateTime.Now.AddDays(2), PriorityLevel.Low);

        project.AddTask(task1);
        project.AddTask(task2);

        var result = project.GetOverdueTasks();

        Assert.Single(result);
        Assert.Equal("Old Task", result[0].Title);
    }

    [Fact]
    public void CompleteTask_Should_MarkTaskAsCompleted()
    {
        var project = new Project("Test Project");
        var task = new Task("Task To Complete", "Some desc", "Charlie", DateTime.Now.AddDays(1), PriorityLevel.Medium);

        project.AddTask(task);
        project.CompleteTask("Task To Complete");

        Assert.True(task.IsCompleted);
    }

    [Fact]
    public void CompleteTask_Should_DoNothing_IfTitleDoesNotMatch()
    {
        var project = new Project("Test Project");
        var task = new Task("Real Task", "desc", "user", DateTime.Now.AddDays(1), PriorityLevel.Low);

        project.AddTask(task);
        project.CompleteTask("Wrong Title");

        Assert.False(task.IsCompleted);
    }

    [Fact]
    public void GetTasksByUser_Should_ReturnOnlyTasksForSpecifiedUser()
    {
        var project = new Project("Test Project");

        var task1 = new ManagementSystem.Task("Task 1", "desc", "Alice", DateTime.Now, PriorityLevel.Low);
        var task2 = new ManagementSystem.Task("Task 2", "desc", "Bob", DateTime.Now, PriorityLevel.Medium);

        project.AddTask(task1);
        project.AddTask(task2);

        var result = project.GetTasksByUser("Alice");

        Assert.Single(result);
        Assert.Equal("Task 1", result[0].Title);
    }

    [Fact]
    public void GetCompletedTasks_Should_ReturnOnlyCompletedTasks()
    {
        var project = new Project("Test Project");

        var task1 = new ManagementSystem.Task("Task 1", "desc", "Alice", DateTime.Now, PriorityLevel.Low);
        var task2 = new ManagementSystem.Task("Task 2", "desc", "Bob", DateTime.Now, PriorityLevel.Medium);

        project.AddTask(task1);
        project.AddTask(task2);
        task1.CompleteTask();

        var result = project.GetCompletedTasks();

        Assert.Single(result);
        Assert.Equal("Task 1", result[0].Title);
    }
}