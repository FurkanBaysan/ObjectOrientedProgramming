using System;

namespace WorkflowEngineDesignApplication
{
    public class SmsService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}