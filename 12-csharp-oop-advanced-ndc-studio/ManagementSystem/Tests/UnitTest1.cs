namespace Tests;

using Xunit;
using ManagementSystem;
using System;

public class UnitTest1
{
    [Fact]
    public void Test_CreateTask_TaskInfo_Display_Title_Descirption_AssignedTo_IsCompleted()
    {
        var task = new Task("Update homepage", "Redesign CSS Presentation Page 2", "Stephan", DateTime.Now.AddDays(-2), PriorityLevel.High);
        var titleEvent = task.Title;
        var descEvent = task.Description;
        var assigneEvent = task.AssignedTo;
        var isCompletedEvent = task.IsCompleted;

        Assert.Equal("Update homepage", titleEvent);
        Assert.Equal("Redesign CSS Presentation Page 2", descEvent);
        Assert.Equal("Stephan", assigneEvent);
        Assert.False(isCompletedEvent);
    }

    [Fact]
    public void Test_CompleteTask_WillBeTrue_When_MethodeHasBeenCalled()
    {
        var task = new Task("Update homepage", "Redesign CSS Presentation Page 2", "Stephan", DateTime.Now.AddDays(-2), PriorityLevel.High);
        var test1 = task.IsCompleted;
        task.CompleteTask();
        var test2 = task.IsCompleted;
        Assert.False(test1);
        Assert.True(test2);
    }


    [Fact]
    public void IsOverdue_ReturnsTrue_WhenDueDatePassed_AndNotCompleted()
    {
        var task = new Task(
            title: "Finish project",
            description: "Complete the final report",
            assignedTo: "Luna",
            dueDate: DateTime.Now.AddDays(-1),
            priority: PriorityLevel.High
        );

        // Non complété
        task.IsCompleted = false;

        Assert.True(task.IsOverdue());
    }

    [Fact]
    public void IsOverdue_ReturnsFalse_WhenTaskIsCompleted()
    {
        var task = new Task(
            title: "Submit CV",
            description: "Email to HR",
            assignedTo: "Chloé",
            dueDate: DateTime.Now.AddDays(-2),
            priority: PriorityLevel.Medium
        );

        task.CompleteTask();

        Assert.False(task.IsOverdue());
    }

    [Fact]
    public void IsOverdue_ReturnsFalse_WhenDueDateIsInFuture()
    {
        var task = new Task(
            title: "Prepare slides",
            description: "For next week’s meeting",
            assignedTo: "Eli",
            dueDate: DateTime.Now.AddDays(2),
            priority: PriorityLevel.Low
        );

        task.IsCompleted = false;

        Assert.False(task.IsOverdue());
    }
}
