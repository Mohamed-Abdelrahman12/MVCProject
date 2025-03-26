using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers
{
    /// <summary>
    /// 1- Any Class must be end with Controller
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #region Summary
        /// <summary>
        /// ------Method Constraints--------
        /// 1- Method Must be public
        /// 2- Can't be static
        /// 3- Can't be overload
        /// 4- Any Public Method in Controller class called => Action
        /// 5- Any URL Can Be Mapping To Class and Action Called => EndPoint
        /// 
        /// ---Action Can Be Return Types ----
        /// 1- String       => ContentResult
        /// 2- View         => ViewResult
        /// 3- Json         => JsonResult
        /// 4- NotFound     => NotFoundResult
        /// 5- Unauthorize  => UnauthorizeResult
        /// ....
        /// ==> All Return Type Are inhirited From ActionResult
        /// ==> And Implemented The IActionResult Interface
        /// </summary> 
        #endregion

        #region EX : Actions
        //public string ShowMassege()
        //{
        //    string massege = "Hello World";
        //    return massege;
        //}

        //public ContentResult ShowMassege()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Hello World...!";
        //    return result;
        //}
        //public ViewResult ViewOne()
        //{
        //    ViewResult viewResult = new ViewResult();
        //    viewResult.ViewName = "ViewOne";
        //    return viewResult;
        //}

        #region Routing
        //------When the Action has one Parameter 
        //Routing ==> Home/MixResult?id=110    ==> ?id=100 --> Query String
        //------Segmant used only with id parameter(Route Parameter)
        //Routing ==> Home/MixResult/100       ==> /100    --> segment

        //------When Have more than Parameter EX -> (int id, string name)
        //Routing ==> Home/MixResult?id=10&name="mohamed"   -> As Query String
        //Routing ==> Home/MixResult/130?name="mohamed"  
        #endregion
        //public IActionResult MixResultV01(int id , string name)
        //{
        //    if(id >= 110)
        //    {
        //        ViewResult viewResult = new ViewResult();
        //        //we can return the same view in more than Action
        //        viewResult.ViewName = "ViewOne"; 
        //        return viewResult;
        //    }
        //    else
        //    {
        //        ContentResult contentResult = new ContentResult();
        //        contentResult.Content = $"Welcome {name} In The Base Of All Type Result..";
        //        return contentResult;
        //    }
        //}
        //public IActionResult MixResult(int id, string name)
        //{
        //    if (id >= 110)
        //        return View("ViewOne");
        //    else
        //        return Content($"Welcome {name} In The Base Of All Type Result..");
        //} 
        #endregion
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
