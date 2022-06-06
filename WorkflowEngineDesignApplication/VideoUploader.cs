using System;

namespace WorkflowEngineDesignApplication
{
    public class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a Video");
        }
    }
}