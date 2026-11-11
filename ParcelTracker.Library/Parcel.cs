
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTrack.Library;

public class Parcel
{
    private readonly List<TrackingEvent> _trackingHistory
        = new List<TrackingEvent>();

    // Properties
    public string TrackingNumber { get; }
    public double WeightKg { get; }
    public ParcelStatus Status { get; private set; }
    public string DeliveryServiceName { get; }
    public DateTime RegisteredDate { get; }

    public Contact Sender { get; }
    public Contact Recipient { get; }

    public IReadOnlyList<TrackingEvent> TrackingHistory
        => _trackingHistory.AsReadOnly();

    // Constructor
    public Parcel(
        string trackingNumber,
        double weightKg,
        Contact sender,
        Contact recipient,
        string deliveryServiceName = "Standard",
        DateTime? registeredDate = null)
    {
        if (string.IsNullOrWhiteSpace(trackingNumber))
            throw new ArgumentException(
                "Tracking number is required.");

        if (weightKg <= 0 ||
            double.IsNaN(weightKg) ||
            double.IsInfinity(weightKg))
            throw new ArgumentOutOfRangeException(
                nameof(weightKg),
                "Weight must be a valid positive number.");

        if (sender == null)
            throw new ArgumentNullException(nameof(sender));

        if (recipient == null)
            throw new ArgumentNullException(nameof(recipient));

        TrackingNumber = trackingNumber;
        WeightKg = weightKg;
        Sender = sender;
        Recipient = recipient;

        DeliveryServiceName = deliveryServiceName;
        RegisteredDate = registeredDate ?? DateTime.Now;

        Status = ParcelStatus.Registered;
    }

    // Add a new tracking event and update parcel status
    internal void AddTrackingEvent(TrackingEvent trackingEvent)
    {
        if (trackingEvent == null)
            throw new ArgumentNullException(nameof(trackingEvent));

        _trackingHistory.Add(trackingEvent);
        Status = trackingEvent.Status;
    }
}
