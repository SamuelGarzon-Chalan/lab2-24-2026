namespace QuestProgressTracker
{
    public class Objective
    {
        public string Name { get; set; }
        public int CurrentAmount { get; set; }
        public int RequiredAmount { get; set; }

        public bool IsCompleted => CurrentAmount >= RequiredAmount;

        public Objective(string name, int requiredAmount)
        {
            Name = name;
            RequiredAmount = requiredAmount < 0 ? 0 : requiredAmount;
            CurrentAmount = 0;
        }

        public void Progress(int amount)
        {
            if (amount <= 0) return;

            int newAmount = CurrentAmount + amount;
            CurrentAmount = newAmount > RequiredAmount ? RequiredAmount : newAmount;
        }
    }
}