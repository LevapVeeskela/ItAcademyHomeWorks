using System;

namespace BusinessLogic.Services.HW_03
{
    public class SecondTaskService : BaseTaskService
    {
        public void RunSecondTask()
        {
            CheckResult(GetUserResult(), GetSumFromStringValue(UserValues.FirstValue, UserValues.SecondValue));
        }
    }
}