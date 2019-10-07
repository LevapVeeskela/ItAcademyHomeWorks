using System;
using Common.Constants;

namespace BusinessLogic.Services.HW_03
{
    public class FirstTaskService : BaseTaskService
    {
        public void RunFirstTask()
        {
            try
            {
                Console.WriteLine($"{HomeWorkThree.TextResultInfo} = {GetSumFromStringValue(UserValues.FirstValue, UserValues.SecondValue).ToString()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format(HomeWorkThree.TextExceptionInfo, e));
            }
        }
    }
}
