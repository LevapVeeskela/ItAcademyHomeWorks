using System;

namespace BusinessLogic.Services.HW_04
{
    public class ТhreeTaskService
    {
        public ТhreeTaskService()
        {
        }

        public void CalculateDeposit(int initialSum, float percent, int countMonth)
        {
            Console.WriteLine($"Начальная сумма: {initialSum}");
            float tempSum = initialSum;
            for (var i = 0; i < countMonth; i++)
            {
                var profit = tempSum * (percent / 100);
                tempSum = tempSum + profit;
                Console.WriteLine($"Текущий месяц: {i + 1}, текущая сумма: {tempSum}, доход за месяц от процентов: {profit}, чистая прибыль: {tempSum - initialSum}");
            }
        }
    }
}