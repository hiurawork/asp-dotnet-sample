using Microsoft.AspNetCore.Mvc;

namespace AspDotNetSampleCode.Controllers
{
    /// <summary>
    /// ユーザのコントロールクラスです。
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// ユーザ作成画面を作成します。
        /// </summary>
        /// <returns>作成された画面を返します。</returns>
        public IActionResult Create()
        {
            return View();
        }
    }
}
