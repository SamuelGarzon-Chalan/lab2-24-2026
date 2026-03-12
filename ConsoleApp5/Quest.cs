using System.Collections.Generic;
using System.Linq;

namespace QuestProgressTracker
{
    public class Quest
    {
        private string name;
        private List<Objective> objectivetime = new List<Objective>();
        private bool isTurnedIn;

        public Quest(string v)
        {
            name = v;
            isTurnedIn = false;
        }

        public bool IsCompleted
        {
            get
            {
                return objectivetime.All(o => o.IsCompleted) && isTurnedIn;
            }
        }

        public void AddObjective(string name, int amount)
        {
            Objective newObjective = new Objective(name, amount);
            objectivetime.Add(newObjective);
        }

        public Objective GetObjective(string name)
        {
            foreach (var objective in objectivetime)
            {
                if (objective.Name == name)
                {
                    return objective;
                }
            }
            return null;
        }

        public void ProgressObjective(string name, int amount)
        {
            foreach (var objective in objectivetime)
            {
                if (objective.Name == name)
                {
                    objective.Progress(amount);
                    return;
                }
            }
        }

        public void TurnIn()
        {
            isTurnedIn = true;
        }
    }
}