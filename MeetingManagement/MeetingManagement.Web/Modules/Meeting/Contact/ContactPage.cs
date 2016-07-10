

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Meeting/Contact", typeof(MeetingManagement.Meeting.Pages.ContactController))]

namespace MeetingManagement.Meeting.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Meeting/Contact"), Route("{action=index}")]
    public class ContactController : Controller
    {
        [PageAuthorize("")]
        public ActionResult Index()
        {
            return View("~/Modules/Meeting/Contact/ContactIndex.cshtml");
        }
    }
}