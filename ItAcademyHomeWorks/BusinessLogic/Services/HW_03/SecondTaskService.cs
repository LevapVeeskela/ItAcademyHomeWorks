using Common.Constants;
using System;

namespace BusinessLogic.Services.HW_03
{
    public class SecondTaskService : BaseTaskService
    {
        public void RunSecondTask()
        {
            try
            {
                CheckResult(GetUserResult(), GetSumFromStringValue(UserValues.FirstValue, UserValues.SecondValue));
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format(Constants.HomeWorkThree.TextExceptionInfo, e));
            }
        }
    }
}