namespace TreeTask.Models
{


    public interface IStep
    {
        string Label { get; }
        string Value { get; }

        TaskStatus Status { get; }

    }
}
