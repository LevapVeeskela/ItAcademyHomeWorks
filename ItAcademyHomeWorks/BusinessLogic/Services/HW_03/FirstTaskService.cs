using System;
using Common.Constants;

namespace BusinessLogic.Services.HW_03
{
    public class FirstTaskService : BaseTaskService
    {
        public void RunFirstTask()
        {
            Console.WriteLine($"{HomeWorkThree.TextResultInfo} = {GetSumFromStringValue(UserValues.FirstValue, UserValues.SecondValue).ToString()}");
        }
    }
}
