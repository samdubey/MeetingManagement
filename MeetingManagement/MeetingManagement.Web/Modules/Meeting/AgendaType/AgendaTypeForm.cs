
namespace MeetingManagement.Meeting.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Meeting.AgendaType")]
    [BasedOnRow(typeof(Entities.AgendaTypeRow))]
    public class AgendaTypeForm
    {
        public String Name { get; set; }
    }
}