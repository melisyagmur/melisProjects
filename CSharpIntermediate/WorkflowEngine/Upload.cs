using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Upload : IWorkflowActivities
    {
        public void Execute(string message)
        {
             Console.WriteLine("completed activity is: {0}", message);
        }
    }
}
