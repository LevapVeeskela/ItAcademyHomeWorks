using System;
using System.Linq;
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
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(HomeWorkSix.TextInfoForEnterRowInfo);
            var rowInfo = row.GetInfoAboutRow();
            var resultRow = row.Replace(rowInfo.MaxWord, string.Empty);
            Console.WriteLine(HomeWorkSix.PatterLengthMaxWordRemove, resultRow);
            Console.WriteLine(HomeWorkFive.FiftyLines);
        }

        public void SwapMaxWithMinLengthWord()
        {
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(HomeWorkSix.TextInfoForEnterRowInfo);
            var rowInfo = row.GetInfoAboutRow();
            var resultRow = row
                .Replace(rowInfo.MaxWord, HomeWorkSix.SwapMaxLengthWordString)
                .Replace(rowInfo.MinWord, rowInfo.MaxWord)
                .Replace(HomeWorkSix.SwapMaxLengthWordString, rowInfo.MinWord);
            Console.WriteLine(HomeWorkSix.PatterSwapMinWithMaxWord, resultRow);
            Console.WriteLine(HomeWorkFive.FiftyLines);
        }

        public void CountLetterAndPunctuationMarksInRow()
        {
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(HomeWorkSix.TextInfoForEnterRowInfo);
            var countLetter = row.GetCountLettersFromRow();
            var countMarks = row.GetCountPunctuationMarksFromRow();
            Console.WriteLine(HomeWorkSix.PatterResultLetterAndMarksInRow, countLetter, countMarks);
            Console.WriteLine(HomeWorkFive.FiftyLines);
        }

        public void ConvertStringInArrayAndSortDescending()
        {
            var row = WriteOrReadConsoleHelper.GetStringValueFromConsole(HomeWorkSix.TextInfoForEnterRowInfo);
            var rowInfo = row.GetInfoAboutRow();
            Console.WriteLine(HomeWorkSix.PatterLengthMinWord, rowInfo.MinWord);
            Console.WriteLine(HomeWorkSix.PatterLengthMaxWord, rowInfo.MaxWord);
            Console.WriteLine(HomeWorkFive.FiftyLines);
            rowInfo.ArrayRow.WriteInConsole();
        }
    }
}
