using Serenity.Navigation;
using Administration = MeetingManagement.Administration.Pages;
using Meeting = MeetingManagement.Meeting.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]

[assembly: NavigationMenu(2000, "Meeting")]
[assembly: NavigationLink(2500, "Meeting/Agenda Types", typeof(Meeting.AgendaTypeController))]
[assembly: NavigationLink(2600, "Meeting/Contacts", typeof(Meeting.ContactController))]
[assembly: NavigationLink(2700, "Meeting/Locations", typeof(Meeting.LocationController))]
[assembly: NavigationLink(2800, "Meeting/Meeting Types", typeof(Meeting.MeetingTypeController))]
[assembly: NavigationLink(2900, "Meeting/Units", typeof(Meeting.UnitController))]

[assembly: NavigationMenu(9000, "Administration", icon: "icon-screen-desktop")]
[assembly: NavigationLink(9100, "Administration/Languages", typeof(Administration.LanguageController), icon: "icon-bubbles")]
[assembly: NavigationLink(9200, "Administration/Translations", typeof(Administration.TranslationController), icon: "icon-speech")]
[assembly: NavigationLink(9300, "Administration/Roles", typeof(Administration.RoleController), icon: "icon-lock")]
[assembly: NavigationLink(9400, "Administration/User Management", typeof(Administration.UserController), icon: "icon-people")]