namespace Infrastructure.Abstractions.Services
{
    public interface ISecondTaskService
    {
        /// <summary>
        /// Удалить из строки самое длинное слово.
        /// </summary>
        void RemoveWordMaxLengthFromRow();

        /// <summary>
        /// Поменять местами самое длинное слово с самым коротким словом
        /// </summary>
        void SwapMaxWithMinLengthWord();

        /// <summary>
        /// Посчитать сколько в строке букв, пунктуационныхзнаков.
        /// </summary>
        void CountLetterAndPunctuationMarksInRow();

        /// <summary>
        /// Преобразовать строку в одномерный массив, используя знак разделителя -пробел. Отсортировать массив по убыванию –первый индекс содержит самое длинное слово, последний –самое короткое.
        /// </summary>
        void ConvertStringInArrayAndSortDescending();
    }
}