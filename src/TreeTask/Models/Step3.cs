namespace TreeTask.Models
{
    public class Step3 : IStep
    {
        public string Label => "Tâche 3";

        public required string Value { get; init; }

        public StepStatus Status { get; init; } = StepStatus.NotStarted;
    }
}
