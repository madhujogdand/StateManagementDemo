using Microsoft.AspNetCore.Mvc;

namespace StateManagementDemo.Controllers
{
    public class ReadCookiesSessionController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ReadCookiesSessionController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult ReadCookie()
        {
            if (_httpContextAccessor.HttpContext != null)
            {
                // read value from Cookie
                ViewBag.Email = _httpContextAccessor.HttpContext.Request.Cookies["email"];
            }
            return View();
        }

        public IActionResult ReadSession()
        {
            ViewBag.Email = HttpContext.Session.GetString("email");
            int? role = HttpContext.Session.GetInt32("roleId");
            return View();
        }


    }
}
