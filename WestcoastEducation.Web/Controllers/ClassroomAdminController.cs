using Microsoft.AspNetCore.Mvc;

namespace WestcoastEducation.Web.Controllers
{
    [Route("classroomadmin")]
    public class ClassroomAdminController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}