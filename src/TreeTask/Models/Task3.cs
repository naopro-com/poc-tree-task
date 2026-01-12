namespace TreeTask.Models
{
    public class Task3 : IStep
    {
        public string Label => "Tâche 3";

        public required string Value { get; init; }

        public TaskStatus Status { get; init; } = TaskStatus.NotStarted;
    }
}
