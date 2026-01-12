namespace TreeTask.Models
{
    public sealed class StepStatus
    {
        public int Id { get; }
        public string Label { get; }

        private StepStatus(int id, string label)
        {
            Id = id;
            Label = label;
        }

        public static readonly StepStatus NotStarted = new(0, "Non commencé");
        public static readonly StepStatus InProgress = new(1, "En cours");
        public static readonly StepStatus Completed = new(2, "Terminé");

        public static IEnumerable<StepStatus> List()
        {
            yield return NotStarted;
            yield return InProgress;
            yield return Completed;
        }

        public static StepStatus FromId(int id)
        {
            var etat = List().FirstOrDefault(e => e.Id == id);
            if (etat == null)
                throw new ArgumentOutOfRangeException(nameof(id), $"Aucun état avec l'id {id}");

            return etat;
        }

        public override string ToString() => Label;
    }
}
