using System;
using Common.Constants;
using Common.Models;
using static System.String;

namespace BusinessLogic.Services.HW_03
{
    public class BaseTaskService
    {
        protected UserValuesModel UserValues;

        public BaseTaskService()
        {
            UserValues = new UserValuesModel
            {
                FirstValue = GetValueFromConsole(HomeWorkThree.TextInfoFirstValueInfo),
                SecondValue = GetValueFromConsole(HomeWorkThree.TextInfoSecondValueInfo)
            };
        }
        protected string GetValueFromConsole(string textInfo)
        {
            Console.WriteLine(textInfo);
            var valueFromConsole = Console.ReadLine();
            while (IsNullOrEmpty(valueFromConsole))
            {
                valueFromConsole = Console.ReadLine();
            }
            return valueFromConsole;
        }

        protected long GetSumFromStringValue(string x, string y)
        {
            return Convert.ToInt64(x) + Convert.ToInt64(y);
        }

        protected void CheckResult(long userResult, long calculateResult)
        {
            var isCorrectly = userResult == calculateResult;
            Console.WriteLine(isCorrectly ? $"{HomeWorkThree.TextCorrectlyInfo}" : $"{HomeWorkThree.TextWrongInfo}");
        }

        protected void СompareResults(long userResult, long result)
        {
            if (userResult != result)
                Console.WriteLine(result > userResult ? HomeWorkThree.TextMustBeMoreInfo : HomeWorkThree.TextMustBeLessInfo);
        }

        protected long GetUserResult()
        {
            return Convert.ToInt64(GetValueFromConsole(HomeWorkThree.TextUserResultInfo));
        }

        protected string GetUserOperator()
        {
            return GetValueFromConsole(HomeWorkThree.TextOperatorInfo);
        }

    }
}