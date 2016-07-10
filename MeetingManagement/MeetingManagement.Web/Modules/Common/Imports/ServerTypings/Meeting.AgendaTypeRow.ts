
namespace MeetingManagement.Meeting {
    export interface AgendaTypeRow {
        AgendaTypeId?: number;
        Name?: string;
    }

    export namespace AgendaTypeRow {
        export const idProperty = 'AgendaTypeId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Meeting.AgendaType';

        export namespace Fields {
            export declare const AgendaTypeId;
            export declare const Name;
        }

        ['AgendaTypeId', 'Name'].forEach(x => (<any>Fields)[x] = x);
    }
}

