using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagementSystem
{
    public class TaskManager
    {
        public List<Project> ProjectList { get; set; }

        public TaskManager()
        {
            ProjectList = [];
        }

        public string AddProject(Project project)
        {
            ProjectList.Add(project);
            return $"The project named {project.Name} has been added successfully.";
        }

        public void GetTasksByAssignedUser(string user)
        {
            foreach (var project in ProjectList)
            {
                project.ListTasksByUser(user);
            }
        }

        public void ListAllOverdueTasks()
        {
            foreach (var project in ProjectList)
            {
                var overdueTasks = project.GetOverdueTasks();
                foreach (var task in overdueTasks)
                {
                    Console.WriteLine(task.Title);
                }
            }
        }


        public void ListAllTasksByPriority(PriorityLevel priority)
        {
            foreach (var project in ProjectList)
            {
                project.ListTaskByPriority(priority);
            }
        }

        public void ListTasksByProject(string projectName)
        {
            var project = ProjectList.FirstOrDefault(p => p.Name == projectName);

            if (project != null)
            {
                foreach (var task in project.TaskList)
                {
                    Console.WriteLine(task.Title);
                }
            }
            else
            {
                Console.WriteLine($"No project founded with the name: {projectName}");
            }
        }


        public void GenerateReport()
        {
            foreach (var project in ProjectList)
            {
                int totalTasks = project.TaskList.Count;
                int completedTasks = project.TaskList.Count(t => t.IsCompleted);
                int overdueTasks = project.GetOverdueTasks().Count;

                Console.WriteLine($"Projet : {project.Name}");
                Console.WriteLine($"- Total of tasks    : {totalTasks}");
                Console.WriteLine($"- Completed tasks  : {completedTasks}");
                Console.WriteLine($"- Overdue tasks   : {overdueTasks}\n");
            }
        }

    }
}