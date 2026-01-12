namespace TreeTask.Models
{
    public class Tree
    {
        public Tree[] Children { get; init; } = Array.Empty<Tree>();
        public required string Id { get; set; }
        public required string Description { get; set; }

        public IStep[] Values { get; init; } = Array.Empty<IStep>();
    }
}
