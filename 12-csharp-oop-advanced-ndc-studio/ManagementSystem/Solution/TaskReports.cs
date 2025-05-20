using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public static class TaskReport
    {
        public static void GenerateProjectReport(Project project)
        {
            Console.WriteLine($"--- Report for Project: {project.Name} ---");

            var completedTasks = project.TaskList.Where(t => t.IsCompleted).ToList();
            var overdueTasks = project.GetOverdueTasks();
            var pendingTasks = project.TaskList.Where(t => !t.IsCompleted && !t.IsOverdue()).ToList();

            Console.WriteLine("\nCompleted Tasks:");
            foreach (var task in completedTasks)
            {
                Console.WriteLine($"- {task.Title}");
            }

            Console.WriteLine("\nOverdue Tasks:");
            foreach (var task in overdueTasks)
            {
                Console.WriteLine($"- {task.Title}");
            }

            Console.WriteLine("\nPending Tasks:");
            foreach (var task in pendingTasks)
            {
                Console.WriteLine($"- {task.Title}");
            }
        }

        public static void GenerateUserReport(string user, TaskManager taskManager)
        {
            Console.WriteLine($"[ Report for User: {user} ]");

            var tasks = new List<Task>();

            foreach (var project in taskManager.ProjectList)
            {
                tasks.AddRange(project.TaskList.Where(t => t.AssignedTo == user));
            }

            var completedTasks = tasks.Where(t => t.IsCompleted).ToList();
            var overdueTasks = tasks.Where(t => t.IsOverdue()).ToList();
            var pendingTasks = tasks.Where(t => !t.IsCompleted && !t.IsOverdue()).ToList();

            Console.WriteLine("\n- Completed Tasks -");
            foreach (var task in completedTasks)
            {
                Console.WriteLine($"- {task.Title}");
            }

            Console.WriteLine("\n- Overdue Tasks -");
            foreach (var task in overdueTasks)
            {
                Console.WriteLine($"- {task.Title}");
            }

            Console.WriteLine("\n- Pending Tasks -");
            foreach (var task in pendingTasks)
            {
                Console.WriteLine($"- {task.Title}");
            }
        }

        public static void GenerateSystemReport(TaskManager taskManager)
        {
            Console.WriteLine("[ System Report ]\n");

            foreach (var project in taskManager.ProjectList)
            {
                int totalTasks = project.TaskList.Count;
                int completedTasks = project.TaskList.Count(t => t.IsCompleted);
                int overdueTasks = project.GetOverdueTasks().Count;

                Console.WriteLine($"○ Project: {project.Name}");
                Console.WriteLine($" • Total Tasks : {totalTasks}");
                Console.WriteLine($" • Completed   : {completedTasks}");
                Console.WriteLine($" • Overdue     : {overdueTasks}");
                Console.WriteLine();
            }
        }
    }
}
