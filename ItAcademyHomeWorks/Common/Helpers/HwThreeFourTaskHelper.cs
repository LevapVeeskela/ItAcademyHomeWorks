using Common.Constants;
using Common.Models;
using System;

namespace Common.Helpers
{
    public static class HwThreeFourTaskHelper
    {
        public static string GetCalculateResult(UserValuesModel values, string userOperator) => userOperator switch
        {
            Constants.Constants.HomeWorkThree.TextPlusOperatorInfo => (Convert.ToInt64(values.FirstValue) + Convert.ToInt64(values.SecondValue)).ToString(),
            Constants.Constants.HomeWorkThree.TextMinusOperatorInfo => (Convert.ToInt64(values.FirstValue) - Convert.ToInt64(values.SecondValue)).ToString(),
            Constants.Constants.HomeWorkThree.TextMultiplyOperatorInfo => (Convert.ToInt64(values.FirstValue) * Convert.ToInt64(values.SecondValue)).ToString(),
            Constants.Constants.HomeWorkThree.TextDivideOperatorInfo => (Convert.ToInt64(values.FirstValue) / Convert.ToInt64(values.SecondValue)).ToString(),
            _ => Constants.Constants.HomeWorkThree.TextNotSupportOperatorInfo
        };
    }
}
