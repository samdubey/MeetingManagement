


namespace MeetingManagement.Meeting.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Meeting/AgendaType"), Route("{action=index}")]
    public class AgendaTypeController : Controller
    {
        [PageAuthorize("Meeting")]
        public ActionResult Index()
        {
            return View("~/Modules/Meeting/AgendaType/AgendaTypeIndex.cshtml");
        }
    }
}