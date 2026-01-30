using Microsoft.AspNetCore.Mvc;

namespace Baker.WebUI.ViewComponents
{
    public class _AdminLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

//ViewComponets ->class
//Shared-Components-aynı isimle klasör- default view
//@await Component.InvokeAsync("_AdminLayoutHeadComponentPartial")