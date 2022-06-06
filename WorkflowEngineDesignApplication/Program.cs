using System;
using System.Collections.Generic;

namespace WorkflowEngineDesignApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Workflow workflow = new Workflow();
            workflow.Add(new MailService());
            workflow.Add(new SmsService());
            workflow.Add(new WebServiceCaller());
            workflow.Add(new VideoUploader());

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
