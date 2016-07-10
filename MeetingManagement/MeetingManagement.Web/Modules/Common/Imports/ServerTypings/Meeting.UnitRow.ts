
namespace MeetingManagement.Meeting {
    export interface UnitRow {
        UnitId?: number;
        Name?: string;
    }

    export namespace UnitRow {
        export const idProperty = 'UnitId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Meeting.Unit';

        export namespace Fields {
            export declare const UnitId;
            export declare const Name;
        }

        ['UnitId', 'Name'].forEach(x => (<any>Fields)[x] = x);
    }
}

