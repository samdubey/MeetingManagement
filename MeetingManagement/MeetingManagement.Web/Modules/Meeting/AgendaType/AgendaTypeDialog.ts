
namespace MeetingManagement.Meeting {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AgendaTypeDialog extends Serenity.EntityDialog<AgendaTypeRow, any> {
        protected getFormKey() { return AgendaTypeForm.formKey; }
        protected getIdProperty() { return AgendaTypeRow.idProperty; }
        protected getLocalTextPrefix() { return AgendaTypeRow.localTextPrefix; }
        protected getNameProperty() { return AgendaTypeRow.nameProperty; }
        protected getService() { return AgendaTypeService.baseUrl; }

        protected form = new AgendaTypeForm(this.idPrefix);
    }
}