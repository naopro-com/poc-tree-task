namespace TreeTask.Models
{
    public class Task1 : IStep
    {
        public string Label => "Tâche 1";

        public required string Value { get; init; }

        public TaskStatus Status { get; init; } = TaskStatus.NotStarted;
    }
}
