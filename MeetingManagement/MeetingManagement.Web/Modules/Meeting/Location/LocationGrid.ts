
namespace MeetingManagement.Meeting {
    
    @Serenity.Decorators.registerClass()
    export class LocationGrid extends Serenity.EntityGrid<LocationRow, any> {
        protected getColumnsKey() { return 'Meeting.Location'; }
        protected getDialogType() { return LocationDialog; }
        protected getIdProperty() { return LocationRow.idProperty; }
        protected getLocalTextPrefix() { return LocationRow.localTextPrefix; }
        protected getService() { return LocationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}