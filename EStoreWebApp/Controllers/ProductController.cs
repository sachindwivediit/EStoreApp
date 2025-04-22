using Microsoft.AspNetCore.Mvc;

namespace EStoreWebApp.Controllers
{
    public class ProductController : Controller
    {
        [Route("/")]
        public string Index()
        {
            return "List of Products";
        }
        [Route("create")]
        public string Create()
        {
            return "Create Products";
        }
    }
}
