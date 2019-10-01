using Common.Constants;
using Common.Models;
using System;

namespace Common.Helpers
{
    public static class HwThreeFourTaskHelper
    {
        public static string GetCalculateResult(UserValuesModel values, string userOperator) => userOperator switch
        {
            HomeWorkThree.TextPlusOperatorInfo => (Convert.ToInt64(values.FirstValue) + Convert.ToInt64(values.SecondValue)).ToString(),
            HomeWorkThree.TextMinusOperatorInfo => (Convert.ToInt64(values.FirstValue) - Convert.ToInt64(values.SecondValue)).ToString(),
            HomeWorkThree.TextMultiplyOperatorInfo => (Convert.ToInt64(values.FirstValue) * Convert.ToInt64(values.SecondValue)).ToString(),
            HomeWorkThree.TextDivideOperatorInfo => (Convert.ToInt64(values.FirstValue) / Convert.ToInt64(values.SecondValue)).ToString(),
            _ => HomeWorkThree.TextNotSupportOperatorInfo
        };
    }
}
