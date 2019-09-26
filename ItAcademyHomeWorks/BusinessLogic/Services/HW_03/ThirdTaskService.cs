using System;

namespace BusinessLogic.Services.HW_03
{
    public class ThirdTaskService : BaseTaskService
    {

        public ThirdTaskService()
        {
        }

        public void RunThreeTask()
        {
            var userResult = GetUserResult();
            var sumResult = GetSumFromStringValue(UserValues.FirstValue, UserValues.SecondValue);
            CheckResult(userResult, sumResult);
            СompareResults(userResult, sumResult);
        }
    }
}