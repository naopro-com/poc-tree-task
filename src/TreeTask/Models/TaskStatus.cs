namespace TreeTask.Models
{
    public sealed class TaskStatus
    {
        public int Id { get; }
        public string Label { get; }

        private TaskStatus(int id, string label)
        {
            Id = id;
            Label = label;
        }

        public static readonly TaskStatus NotStarted = new(0, "Non commencé");
        public static readonly TaskStatus InProgress = new(1, "En cours");
        public static readonly TaskStatus Completed = new(2, "Terminé");

        public static IEnumerable<TaskStatus> List()
        {
            yield return NotStarted;
            yield return InProgress;
            yield return Completed;
        }

        public static TaskStatus FromId(int id)
        {
            var etat = List().FirstOrDefault(e => e.Id == id);
            if (etat == null)
                throw new ArgumentOutOfRangeException(nameof(id), $"Aucun état avec l'id {id}");

            return etat;
        }

        public override string ToString() => Label;
    }
}
