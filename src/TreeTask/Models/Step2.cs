namespace TreeTask.Models
{
    public class Step2 : IStep
    {
        public string Label => "Tâche 2";

        public required string Value { get; init; }

        public StepStatus Status { get; init; } = StepStatus.NotStarted;
    }
}
