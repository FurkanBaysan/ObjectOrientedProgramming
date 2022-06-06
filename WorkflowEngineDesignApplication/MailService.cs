using System;

namespace WorkflowEngineDesignApplication
{
    public class MailService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an Email...");
        }
    }
}