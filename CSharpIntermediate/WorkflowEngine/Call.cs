using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Call : IWorkflowActivities
    {
        public void Execute(string message)
        {
          
            Console.WriteLine("OUR MESSAGE IS: {0}", message);
        }
    }
}
