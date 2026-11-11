
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParcelTrack.Library;

public class ParcelTracker
{
    private readonly List<Parcel> _parcels =
        new List<Parcel>();

    // Get all registered parcels
    public IReadOnlyList<Parcel> Parcels =>
        _parcels.AsReadOnly();

    // Register a new parcel
    public void RegisterParcel(Parcel parcel)
    {
        if (parcel == null)
            throw new ArgumentNullException(nameof(parcel));

        bool alreadyExists = _parcels.Any(
            p => p.TrackingNumber.Equals(
                parcel.TrackingNumber,
                StringComparison.OrdinalIgnoreCase));

        if (alreadyExists)
            throw new InvalidOperationException(
                "Tracking number already exists.");

        _parcels.Add(parcel);
    }

    // Find a parcel using its tracking number
    public Parcel FindParcel(string trackingNumber)
    {
        if (string.IsNullOrWhiteSpace(trackingNumber))
            return null;

        return _parcels.FirstOrDefault(
            p => p.TrackingNumber.Equals(
                trackingNumber,
                StringComparison.OrdinalIgnoreCase));
    }

    // Get tracking history of a parcel
    public IReadOnlyList<TrackingEvent> GetTrackingHistory(
        string trackingNumber)
    {
        Parcel parcel = FindParcel(trackingNumber);

        if (parcel == null)
            return new List<TrackingEvent>();

        return parcel.TrackingHistory;
    }
}
