
namespace MeetingManagement.Meeting {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class UnitDialog extends Serenity.EntityDialog<UnitRow, any> {
        protected getFormKey() { return UnitForm.formKey; }
        protected getIdProperty() { return UnitRow.idProperty; }
        protected getLocalTextPrefix() { return UnitRow.localTextPrefix; }
        protected getNameProperty() { return UnitRow.nameProperty; }
        protected getService() { return UnitService.baseUrl; }

        protected form = new UnitForm(this.idPrefix);
    }
}