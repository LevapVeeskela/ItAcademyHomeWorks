namespace Common.Models
{
    public class RowInfoModel
    {
        /// <summary>
        /// OriginRow
        /// </summary>
        public string OriginRow { get; set; }

        /// <summary>
        /// Dividing row by string
        /// </summary>
        public string[] ArrayRow { get; set; }

        /// <summary>
        /// Word max lighting in row
        /// </summary>
        public string MaxWord { get; set; }

        /// <summary>
        /// Word min lighting in row
        /// </summary>
        public string MinWord { get; set; }
    }
}
