namespace InterfaceAppConsole
{
    public class Worker
    {
        public void DoWork(IJob job)
        {
            if (job != null)
            {
                job.DoJob();
            }
        }
    }
}
