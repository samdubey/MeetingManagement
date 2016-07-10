
namespace MeetingManagement.Meeting.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Meeting.Unit")]
    [BasedOnRow(typeof(Entities.UnitRow))]
    public class UnitForm
    {
        public String Name { get; set; }
    }
}