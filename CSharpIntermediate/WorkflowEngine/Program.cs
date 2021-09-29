using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorkflowActivities> worklist = new List<IWorkflowActivities>
            {
                new Upload(),
                new Call()
            };

            var workflow = new WorkfEngine(worklist);
            workflow.Run("yes");
        }
    } 
}
