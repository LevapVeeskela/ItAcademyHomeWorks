using System;
using System.Threading;
using Common.Constants;
using Common.Helpers;

namespace BusinessLogic.Services.HW_03
{
    public class FourthTaskService : BaseTaskService
    {
        public void RunFourthTask()
        {
            try
            {
                var userOperator = GetUserOperator();
                var userResult = GetUserResult();
                var result = HwThreeFourTaskHelper.GetCalculateResult(UserValues, userOperator);
                CheckResult(userResult, result);
                СompareResults(userResult, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format(HomeWorkThree.TextExceptionInfo, e));
            }
        }
    }
}