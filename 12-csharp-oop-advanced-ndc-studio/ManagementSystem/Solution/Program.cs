namespace ManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Create the taskMAnager */
            var taskManager = new TaskManager();

            /* Create two projects */
            var project1 = new Project("Porte Folio");
            var project2 = new Project("Web Site");

            /* Create tasks */
            Task task1 = new Task("Update homepage", "Redesign CSS Presentation Page 2", "Stephan", DateTime.Now.AddDays(-2), PriorityLevel.High);

            Task task2 = new Task("Design screen", "Do responsive design", "Charlie", DateTime.Now.AddDays(-1), PriorityLevel.Low);

            Task task3 = new Task("WebShop", "Write a code for sell NDC-Studio's Resources", "Alice", DateTime.Now.AddDays(1), PriorityLevel.Medium);

            Task task4 = new Task("Fix login bug", "Resolve user login issue", "Bob", DateTime.Now.AddDays(3), PriorityLevel.Critical);

            /* Add tasks to Projects */
            project1.AddTask(task1);
            project1.AddTask(task2);
            project2.AddTask(task3);
            project2.AddTask(task4);

            /* Complete a task */
            task2.CompleteTask();

            /* Add projects to task manager */
            taskManager.AddProject(project1);
            taskManager.AddProject(project2);

            /* Display overdue tasks */
            Console.WriteLine("[ Overdue Tasks ]");
            taskManager.ListAllOverdueTasks();

            /* Display tasks by priority */
            Console.WriteLine("\n[ High Priority Tasks ]");
            taskManager.ListAllTasksByPriority(PriorityLevel.High);

            /* Display tasks by user */
            Console.WriteLine("\n[ Tasks Assigned to Alice ]");
            taskManager.GetTasksByAssignedUser("Alice");

            /* Generate system summary report */
            Console.WriteLine("\n[ System Report ]");
            TaskReport.GenerateSystemReport(taskManager);

            /* Generate report for a specific project */
            Console.WriteLine("\n[ Project Report: Website Redesign ]");
            TaskReport.GenerateProjectReport(project1);

            /* Generate report for a specific user */
            Console.WriteLine("\n[[ User Report: Alice ]]");
            TaskReport.GenerateUserReport("Alice", taskManager);

            /* Exit */
            Console.WriteLine("\nPress any key to exit.\n");
            Console.ReadKey();
        }
    }
}