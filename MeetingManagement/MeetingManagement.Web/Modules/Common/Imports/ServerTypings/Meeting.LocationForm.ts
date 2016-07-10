

namespace MeetingManagement.Meeting {
    export class LocationForm extends Serenity.PrefixedContext {
        static formKey = 'Meeting.Location';
    }

    export interface LocationForm {
        Name: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Latitude: Serenity.DecimalEditor;
        Longitude: Serenity.DecimalEditor;
    }

    [['Name', () => Serenity.StringEditor], ['Address', () => Serenity.StringEditor], ['Latitude', () => Serenity.DecimalEditor], ['Longitude', () => Serenity.DecimalEditor]].forEach(x => Object.defineProperty(LocationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}