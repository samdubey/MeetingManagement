
namespace MeetingManagement.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class AgendaTypeGrid extends Serenity.EntityGrid<AgendaTypeRow, any> {
        protected getColumnsKey() { return 'Meeting.AgendaType'; }
        protected getDialogType() { return AgendaTypeDialog; }
        protected getIdProperty() { return AgendaTypeRow.idProperty; }
        protected getLocalTextPrefix() { return AgendaTypeRow.localTextPrefix; }
        protected getService() { return AgendaTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}