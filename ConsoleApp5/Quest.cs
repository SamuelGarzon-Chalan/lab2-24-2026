using System.Runtime.CompilerServices;
using QuestProgressTracker;
namespace QuestProgressTracker
{
    public class Quest
    {
        private string name ; //v = nMEW
        private List<Objective> objectivetime = new List<Objective>();
        public Quest(string v)
        {
          

            //this.v = v;
        }

        public bool IsCompleted
        {
            get 
            { return objectivetime.All(o => o.Iscompleted); }
        }

        public void AddObjective(string name, int amount) => objectivetimeAdd(new Objective { Name, RequiredAmount });

        public Objective GetObjective(string name , int amount )
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

        public void ProgressObjective(string name )
       
    }
}
