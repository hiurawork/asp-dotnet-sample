namespace AspDotNetSampleCode.Models
{
    /// <summary>
    /// カードデータのモデルクラスです。
    /// </summary>
    public class CardDataModel
    {
        /// <summary>
        /// 写真です。
        /// </summary>
        public string? Image { get; set; }

        /// <summary>
        /// 名前です。
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 価格です。
        /// </summary>
        public int? Price { get; set; }

        /// <summary>
        /// 備考です。
        /// </summary>
        public string? Note { get; set; }
    }
}
