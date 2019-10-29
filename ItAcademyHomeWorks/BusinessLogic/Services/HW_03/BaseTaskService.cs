using System;
using Common.Constants;
using Common.Models;
using static System.String;

namespace BusinessLogic.Services.HW_03
{
    public class BaseTaskService
    {
        protected UserValuesModel UserValues { get; set; }

        protected BaseTaskService()
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

        protected string GetSumFromStringValue(string x, string y)
        {
            return (Convert.ToInt64(x) + Convert.ToInt64(y)).ToString();
        }

        protected void CheckResult(long userResult, string calculateResult)
        {
            if (long.TryParse(calculateResult, out long longValue))
            {
                Console.WriteLine(userResult == longValue ? $"{HomeWorkThree.TextCorrectlyInfo}" : $"{HomeWorkThree.TextWrongInfo}");
            }
            else
            {
                Console.WriteLine(calculateResult);
            }
        }

        protected void СompareResults(long userResult, string result)
        {
            if (long.TryParse(result, out long longValue) && userResult != longValue)
                Console.WriteLine(longValue > userResult ? HomeWorkThree.TextMustBeMoreInfo : HomeWorkThree.TextMustBeLessInfo);
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