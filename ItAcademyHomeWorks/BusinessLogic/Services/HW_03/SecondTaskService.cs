using System;

namespace BusinessLogic.Services.HW_03
{
    public class SecondTaskService : BaseTaskService
    {

        public SecondTaskService()
        {
        }

        public void RunSecondTask()
        {
            CheckResult(GetUserResult(), GetSumFromStringValue(UserValues.FirstValue, UserValues.SecondValue));
        }
    }
}