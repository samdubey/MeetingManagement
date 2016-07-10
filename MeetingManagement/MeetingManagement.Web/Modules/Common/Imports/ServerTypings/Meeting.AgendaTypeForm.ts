

namespace MeetingManagement.Meeting {
    export class AgendaTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Meeting.AgendaType';
    }

    export interface AgendaTypeForm {
        Name: Serenity.StringEditor;
    }

    [['Name', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(AgendaTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}