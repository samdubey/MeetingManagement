

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Meeting/MeetingType", typeof(MeetingManagement.Meeting.Pages.MeetingTypeController))]

namespace MeetingManagement.Meeting.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Meeting/MeetingType"), Route("{action=index}")]
    public class MeetingTypeController : Controller
    {
        [PageAuthorize("")]
        public ActionResult Index()
        {
            return View("~/Modules/Meeting/MeetingType/MeetingTypeIndex.cshtml");
        }
    }
}