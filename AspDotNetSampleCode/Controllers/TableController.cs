using Microsoft.AspNetCore.Mvc;
using AspDotNetSampleCode.Models;

namespace AspDotNetSampleCode.Controllers
{
    /// <summary>
    /// テーブル用のコントローラクラスです。
    /// </summary>
    public class TableController : Controller
    {
        /// <summary>
        /// 画面を作成します。
        /// </summary>
        /// <returns>作成された画面を返します。</returns>
        public IActionResult Index()
        {
            List<TableDataModel> datas = GetTableDatas();
            ViewBag.Datas = datas;

            string yourName = "bbbbb";
            ViewData["mame"] = yourName;

            return View(datas);
        }

        private List<TableDataModel> GetTableDatas()
        {
            List<TableDataModel> datas = new List<TableDataModel>();

            for (int i = 0; i < 50; i++)
            {
                TableDataModel data = new TableDataModel();
                data.Name = "テスト　太郎";
                data.Age = "30";
                data.Gender = "男";
                data.PhoneNumber = "000-0000-0000";
                datas.Add(data);
            }

            return datas;
        }
    }
}
