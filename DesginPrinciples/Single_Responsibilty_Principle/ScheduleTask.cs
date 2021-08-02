using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Single_Responsibilty_Principle
{
    public class ScheduleTask
    {
        public int TaskId { get; set; }
        public string Content { get; set; }
        public DateTime ExecuteOn { get; set; }
    }
}