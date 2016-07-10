
namespace MeetingManagement.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class UnitGrid extends Serenity.EntityGrid<UnitRow, any> {
        protected getColumnsKey() { return 'Meeting.Unit'; }
        protected getDialogType() { return UnitDialog; }
        protected getIdProperty() { return UnitRow.idProperty; }
        protected getLocalTextPrefix() { return UnitRow.localTextPrefix; }
        protected getService() { return UnitService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}