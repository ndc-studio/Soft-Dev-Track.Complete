using System;

namespace ManagementSystem
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
        public PriorityLevel Priority { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title, string description, string assignedTo, DateTime dueDate, PriorityLevel priority)
        {
            Title = title;
            Description = description;
            AssignedTo = assignedTo;
            DueDate = dueDate;
            Priority = priority;
            IsCompleted = false;
        }

        public void CompleteTask()
        {
            IsCompleted = true;
        }

        public bool IsOverdue()
        {
            return !IsCompleted && DateTime.Now > DueDate;
        }

    }
}