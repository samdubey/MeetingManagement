


namespace MeetingManagement.Meeting.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Meeting/Location"), Route("{action=index}")]
    public class LocationController : Controller
    {
        [PageAuthorize("")]
        public ActionResult Index()
        {
            return View("~/Modules/Meeting/Location/LocationIndex.cshtml");
        }
    }
}