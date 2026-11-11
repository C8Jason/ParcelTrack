
using System;

namespace ParcelTrack.Library;

public class TrackingManager
{
    public void AddTrackingEvent(
        Parcel parcel,
        TrackingEvent trackingEvent)
    {
        if (parcel == null)
            throw new ArgumentNullException(nameof(parcel));

        if (trackingEvent == null)
            throw new ArgumentNullException(nameof(trackingEvent));

        parcel.AddTrackingEvent(trackingEvent);
    }

    public ParcelStatus GetCurrentStatus(Parcel parcel)
    {
        if (parcel == null)
            throw new ArgumentNullException(nameof(parcel));

        return parcel.Status;
    }
}
