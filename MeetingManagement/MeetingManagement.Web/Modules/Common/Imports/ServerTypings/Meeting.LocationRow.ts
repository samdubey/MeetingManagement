
namespace MeetingManagement.Meeting {
    export interface LocationRow {
        LocationId?: number;
        Name?: string;
        Address?: string;
        Latitude?: number;
        Longitude?: number;
    }

    export namespace LocationRow {
        export const idProperty = 'LocationId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Meeting.Location';

        export namespace Fields {
            export declare const LocationId;
            export declare const Name;
            export declare const Address;
            export declare const Latitude;
            export declare const Longitude;
        }

        ['LocationId', 'Name', 'Address', 'Latitude', 'Longitude'].forEach(x => (<any>Fields)[x] = x);
    }
}

