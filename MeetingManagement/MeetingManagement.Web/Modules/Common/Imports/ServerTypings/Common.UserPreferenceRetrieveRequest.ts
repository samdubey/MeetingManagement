namespace MeetingManagement.Common {
    export interface UserPreferenceRetrieveRequest extends Serenity.ServiceRequest {
        PreferenceType?: string
        Name?: string
    }
}

