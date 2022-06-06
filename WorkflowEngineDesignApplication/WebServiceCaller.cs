using System;

namespace WorkflowEngineDesignApplication
{
    public class WebServiceCaller : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web Service...");
        }
    }
}