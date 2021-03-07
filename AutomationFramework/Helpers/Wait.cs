using System;
using System.Threading;


namespace AutomationFramework.Helpers
{
    public class Wait
    {
        public static void Until(Func<bool> predicate, string assertionFailureMessage, int waitMilliseconds = 500,int maxRetry = 10)
        {
            while (maxRetry-- > 0)
            {
                try
                {
                    if (!predicate())
                    {
                        Thread.Sleep(waitMilliseconds);
                        continue;
                    }
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"The exception was thrown at {maxRetry}" + e.StackTrace);
                    throw;
                }
            }
        }

        public static void UntilNoAssertionFailure(Action assertionAction, string assertionFailureMessage,
            int waitMilliseconds = 500, int maxRetry = 10)
        {
            while (maxRetry-- > 0 )
            {
                try
                {
                    assertionAction();
                }
                catch (Exception e)
                {
                    if (maxRetry -1 == 0)
                    {
                        throw;
                    }
                    Thread.Sleep(waitMilliseconds);
                }
                return;
            }

            throw new Exception(assertionFailureMessage);
            //Assert.Fail(assertionFailureMessage);
        }
    }
}
