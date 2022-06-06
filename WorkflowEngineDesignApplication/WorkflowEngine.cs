using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineDesignApplication
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask task in workflow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception exception)
                {
                    // Logging
                    // Terminate and persist the state of workflow
                }
            }
        }

    }
}
