using System.Web.Mvc;
using FileManagerInMVC.Web.Models;

namespace FileManagerInMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public virtual ActionResult Index(string subFolder)
        {
            FileViewModel model = new FileViewModel { Folder = "Files", SubFolder = subFolder };
            return View(model);
        }
    }
}