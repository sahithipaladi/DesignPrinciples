using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace DesignPrinciples.Single_Responsibilty_Principle
{
    public class Scheduler : IEntryManager<ScheduleTask>
    {
        private List<ScheduleTask> scheduleTasks;
        public Scheduler()
        {
            scheduleTasks = new List<ScheduleTask>();
        }
        // Add data in the list.......
        public new void AddEntry(ScheduleTask entry)
        {
            scheduleTasks.Add(entry);
        }
        // Remove At the index using lambda expression............
        public new void RemoveEntryAt(int index) => scheduleTasks.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, scheduleTasks.Select(x => $" Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
    }
}