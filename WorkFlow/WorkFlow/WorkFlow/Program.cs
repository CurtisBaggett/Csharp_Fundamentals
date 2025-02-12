using System;
using System.Collections.Generic;

namespace WorkFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            var workFlow = new WorkFlow();
            workFlow.Add(new UploadVideo());
            workFlow.Add(new EncodeVideo());
            workFlow.Add(new EmailNotification());
            workFlow.Add(new ProcessingVideo());

            var engine = new Engine();
            engine.Run(workFlow);

        }
    }

    public interface ITask
    {
        void Execute();
    }

    public interface IWorkFlow
    {
        public void Add(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    public class WorkFlow : IWorkFlow
    {

        private readonly IList<ITask> _task;
        public WorkFlow()
        {
            _task = new List<ITask>();
        }
        public void Add(ITask task)
        {
            _task.Add(task);
        }
        public IEnumerable<ITask> GetTasks()
        {
            return _task;
        }
    }

    public class Engine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach(var work in workFlow.GetTasks())
            {
                work.Execute();
            }
        }
    }
    public class UploadVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud service...");
        }
    }

    public class EncodeVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Encoding video...");
        }
    }

    public class EmailNotification : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending email that processing has started...");
        }
    }

    public class ProcessingVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Processing video...");
        }
    }

    
}
