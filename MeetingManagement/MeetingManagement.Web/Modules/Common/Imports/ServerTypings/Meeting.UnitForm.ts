

namespace MeetingManagement.Meeting {
    export class UnitForm extends Serenity.PrefixedContext {
        static formKey = 'Meeting.Unit';
    }

    export interface UnitForm {
        Name: Serenity.StringEditor;
    }

    [['Name', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(UnitForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}