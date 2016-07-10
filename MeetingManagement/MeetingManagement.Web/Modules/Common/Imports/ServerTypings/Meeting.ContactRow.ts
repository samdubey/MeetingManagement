
namespace MeetingManagement.Meeting {
    export interface ContactRow {
        ContactId?: number;
        Title?: string;
        FirstName?: string;
        LastName?: string;
        Email?: string;
    }

    export namespace ContactRow {
        export const idProperty = 'ContactId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Meeting.Contact';

        export namespace Fields {
            export declare const ContactId;
            export declare const Title;
            export declare const FirstName;
            export declare const LastName;
            export declare const Email;
        }

        ['ContactId', 'Title', 'FirstName', 'LastName', 'Email'].forEach(x => (<any>Fields)[x] = x);
    }
}

