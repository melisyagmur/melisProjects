using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkfEngine
    {
        private readonly List<IWorkflowActivities> _workflowList = new List<IWorkflowActivities>();
   
        public WorkfEngine(List<IWorkflowActivities> activities)
        {
            _workflowList = activities;
        }
        public void Run(string message)
        {
            foreach (var item in _workflowList)
            {
                item.Execute(message);
            }

        }
    }
}
