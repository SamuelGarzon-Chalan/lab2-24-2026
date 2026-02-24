namespace QuestProgressTracker
{

    public class Objective
    {
        public string Name { get; set; }
        public int CurrentAmount { get; set; }
        public int RequiredAmount { get; set; }

        public bool Iscompleted => CurrentAmount >= RequiredAmount;

        public Objective()
        {
            Name = Name;
            RequiredAmount = RequiredAmount < 0 ? 0 : RequiredAmount ;
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
