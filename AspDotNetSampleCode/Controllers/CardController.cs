using AspDotNetSampleCode.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetSampleCode.Controllers
{
    /// <summary>
    /// カード用のコントローラクラスです。
    /// </summary>
    public class CardController : Controller
    {
        /// <summary>
        /// 画面を作成します。
        /// </summary>
        /// <returns>作成された画面を返します。</returns>
        public IActionResult Index()
        {
            List<CardDataModel> datas = GetCardDatas();
            ViewBag.Datas = datas;

            return View();
        }

        /// <summary>
        /// カードに表示するデータの一覧を取得します。
        /// </summary>
        /// <returns>取得されたデータを返します。</returns>
        private List<CardDataModel> GetCardDatas()
        {
            List<CardDataModel> datas = new List<CardDataModel>();
            byte[] byteData = System.IO.File.ReadAllBytes("./img/nori-bento.png");
            string imreBase64Data = Convert.ToBase64String(byteData);
            string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);

            for (int i = 0; i < 20; i++)
            {
                CardDataModel data = new CardDataModel();
                data.Image = imgDataURL;
                data.Name = "のり弁当";
                data.Price = 500;
                data.Note = "※ おひとり様3個限定です。";

                datas.Add(data);
            }

            return datas;
        }
    }
}
