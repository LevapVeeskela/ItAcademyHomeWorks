using System;
using System.Threading;
using Common.Constants;

namespace BusinessLogic.Services.HW_03
{
    public class FourthTaskService : BaseTaskService
    {
        public FourthTaskService()
        {
        }

        public void RunFourthTask()
        {
            var userOperator = GetUserOperator();
            var userResult = GetUserResult();
            var result = GetCalculateResult(userOperator);
            CheckResult(userResult, result);
            СompareResults(userResult, result);
        }

        private long GetCalculateResult(string userOperator)
        {
            long result = 0;

            switch (userOperator)
            {
                case "+":
                    result = Convert.ToInt64(UserValues.FirstValue) + Convert.ToInt64(UserValues.SecondValue);
                    break;
                case "-":
                    result = Convert.ToInt64(UserValues.FirstValue) - Convert.ToInt64(UserValues.SecondValue);
                    break;
                case "*":
                    result = Convert.ToInt64(UserValues.FirstValue) * Convert.ToInt64(UserValues.SecondValue);
                    break;
                case "/":
                    result = Convert.ToInt64(UserValues.FirstValue) / Convert.ToInt64(UserValues.SecondValue);
                    break;
                default:
                    Console.WriteLine(HomeWorkThree.TextNotSupportOperatorInfo);
                    break;
            }

            return result;
        }
    }
}