namespace TreeTask.Models
{
    public class Task2 : IStep
    {
        public string Label => "Tâche 2";

        public required string Value { get; init; }

        public TaskStatus Status { get; init; } = TaskStatus.NotStarted;
    }
}
