using Microsoft.AspNetCore.Mvc;

namespace AspDotNetSampleCode.Controllers
{
    /// <summary>
    /// ログイン用のコントローラクラスです。
    /// </summary>
    public class LoginController : Controller
    {
        /// <summary>
        /// 画面を作成します。
        /// </summary>
        /// <returns>作成された画面を返します。</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
