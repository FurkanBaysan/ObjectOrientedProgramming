using System.Collections.Generic;

namespace WorkflowEngineDesignApplication
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}