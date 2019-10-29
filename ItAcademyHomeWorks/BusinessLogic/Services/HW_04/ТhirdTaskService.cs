using System;

namespace BusinessLogic.Services.HW_04
{
    public class ТhirdTaskService
    {
        public void CalculateDeposit(int initialSum = 1000, float percent = 2, int countMonth = 12)
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