using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestJobs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesthangfireManager()
        {
            JobsManager.HangfireManager hangfireManager = new JobsManager.HangfireManager();
            hangfireManager.Run();
        }
    }
}
