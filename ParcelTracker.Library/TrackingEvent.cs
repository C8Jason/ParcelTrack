
using System;

namespace ParcelTrack.Library
{
    public class TrackingEvent
    {
        public ParcelStatus Status { get; }
        public string Location { get; }
        public DateTime Timestamp { get; }
        public string Description { get; }

        // Original constructor used by the GUI
        public TrackingEvent(
            ParcelStatus status,
            string location,
            string description)
            : this(status, location, description, DateTime.Now)
        {
        }

        // Constructor used when restoring saved tracking history
        public TrackingEvent(
            ParcelStatus status,
            string location,
            string description,
            DateTime timestamp)
        {
            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("Location is required.");

            Status = status;
            Location = location;
            Description = description ?? string.Empty;
            Timestamp = timestamp;
        }
    }
}
