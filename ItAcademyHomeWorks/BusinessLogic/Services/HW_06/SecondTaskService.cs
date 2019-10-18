using System;
using Common.Constants;
using Common.Extensions;
using Common.Helpers;
using Infrastructure.Abstractions.Services;

namespace BusinessLogic.Services.HW_06
{
    public class SecondTaskService : ISecondTaskService
    {
        public void RemoveWordMaxLengthFromRow()
        {
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(Constants.HomeWorkSix.TextInfoForEnterRowInfo);
            var rowInfo = row.GetInfoAboutRow();
            var resultRow = row.Replace(rowInfo.MaxWord, string.Empty);
            Console.WriteLine(Constants.HomeWorkSix.PatterLengthMaxWordRemove, resultRow);
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
        }

        public void SwapMaxWithMinLengthWord()
        {
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(Constants.HomeWorkSix.TextInfoForEnterRowInfo);
            var rowInfo = row.GetInfoAboutRow();
            var resultRow = row
                .Replace(rowInfo.MaxWord, Constants.HomeWorkSix.SwapMaxLengthWordString)
                .Replace(rowInfo.MinWord, rowInfo.MaxWord)
                .Replace(Constants.HomeWorkSix.SwapMaxLengthWordString, rowInfo.MinWord);
            Console.WriteLine(Constants.HomeWorkSix.PatterSwapMinWithMaxWord, resultRow);
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
        }

        public void CountLetterAndPunctuationMarksInRow()
        {
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(Constants.HomeWorkSix.TextInfoForEnterRowInfo);
            var countLetter = row.GetCountLettersFromRow();
            var countMarks = row.GetCountPunctuationMarksFromRow();
            Console.WriteLine(Constants.HomeWorkSix.PatterResultLetterAndMarksInRow, countLetter, countMarks);
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
        }

        public void ConvertStringInArrayAndSortDescending()
        {
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(Constants.HomeWorkSix.TextInfoForEnterRowInfo);
            var rowInfo = row.GetInfoAboutRow();
            Console.WriteLine(Constants.HomeWorkSix.PatterLengthMinWord, rowInfo.MinWord);
            Console.WriteLine(Constants.HomeWorkSix.PatterLengthMaxWord, rowInfo.MaxWord);
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            rowInfo.ArrayRow.WriteInConsole();
        }
    }
}
