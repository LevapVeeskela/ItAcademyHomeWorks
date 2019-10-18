using Common.Constants;
using System;

namespace BusinessLogic.Services.HW_03
{
    public class ThirdTaskService : BaseTaskService
    {
        public void RunThreeTask()
        {
            try
            {
                var userResult = GetUserResult();
                var sumResult = GetSumFromStringValue(UserValues.FirstValue, UserValues.SecondValue);
                CheckResult(userResult, sumResult.ToString());
                СompareResults(userResult, sumResult.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format(Constants.HomeWorkThree.TextExceptionInfo, e));
            }
        }
    }
}