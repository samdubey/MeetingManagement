

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Meeting/Unit", typeof(MeetingManagement.Meeting.Pages.UnitController))]

namespace MeetingManagement.Meeting.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Meeting/Unit"), Route("{action=index}")]
    public class UnitController : Controller
    {
        [PageAuthorize("Meeting")]
        public ActionResult Index()
        {
            return View("~/Modules/Meeting/Unit/UnitIndex.cshtml");
        }
    }
}