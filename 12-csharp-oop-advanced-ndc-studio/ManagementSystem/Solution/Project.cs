using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public class Project
    {
        public string Name { get; set; }
        public List<Task> TaskList { get; set; }

        public Project(string name)
        {
            Name = name;
            TaskList = [];
        }

        public void AddTask(Task task)
        {
            TaskList.Add(task);
        }

        public List<Task> GetOverdueTasks()
        {
            List<Task> overdueTasks = new();

            foreach (var task in TaskList)
            {
                if (task.IsOverdue())
                {
                    overdueTasks.Add(task);
                }
            }

            return overdueTasks;
        }


        public void ListTaskByPriority(PriorityLevel priority)
        {
            foreach (var task in TaskList)
            {
                if (task.Priority == priority)
                {
                    Console.WriteLine(task.Title);
                }
            }
        }

        public void CompleteTask(string title)
        {
            foreach (var task in TaskList)
            {
                if (task.Title == title)
                {
                    task.CompleteTask();
                    break;
                }
            }
        }

        public void ListTasksByUser(string user)
        {
            foreach (var task in TaskList)
            {
                if (task.AssignedTo == user)
                {
                    Console.WriteLine(task.Title);
                }
            }
        }

        public void ListCompletedTasks()
        {
            foreach (var task in TaskList)
            {
                if (task.IsCompleted)
                {
                    Console.WriteLine(task.Title);
                }
            }
        }

        public List<Task> GetTasksByUser(string user)
        {
            return TaskList.Where(task => task.AssignedTo == user).ToList();
        }

        public List<Task> GetCompletedTasks()
        {
            return TaskList.Where(task => task.IsCompleted).ToList();
        }
    }
}
