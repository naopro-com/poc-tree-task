namespace TreeTask.Models
{
    public class Step1 : IStep
    {
        public string Label => "Tâche 1";

        public required string Value { get; init; }

        public StepStatus Status { get; init; } = StepStatus.NotStarted;
    }
}
