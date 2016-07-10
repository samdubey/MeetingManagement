
namespace MeetingManagement.Meeting.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Meeting.AgendaType")]
    [BasedOnRow(typeof(Entities.AgendaTypeRow))]
    public class AgendaTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 AgendaTypeId { get; set; }
        [EditLink]
        public String Name { get; set; }
    }
}