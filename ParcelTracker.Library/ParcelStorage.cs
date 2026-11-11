using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ParcelTrack.Library
{
    public class ParcelStorage
    {
        private readonly string _filePath;

        public ParcelStorage()
        {
            _filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "parcels.json");
        }

        // Save all parcels to JSON
        public void Save(IEnumerable<Parcel> parcels)
        {
            List<ParcelData> data = new List<ParcelData>();

            foreach (Parcel parcel in parcels)
            {
                ParcelData parcelData = new ParcelData
                {
                    TrackingNumber = parcel.TrackingNumber,
                    WeightKg = parcel.WeightKg,
                    Status = parcel.Status,
                    DeliveryServiceName = parcel.DeliveryServiceName,
                    RegisteredDate = parcel.RegisteredDate,
                    Sender = new ContactData
                    {
                        Name = parcel.Sender.Name,
                        PhoneNumber = parcel.Sender.PhoneNumber,
                        Address = parcel.Sender.Address
                    },
                    Recipient = new ContactData
                    {
                        Name = parcel.Recipient.Name,
                        PhoneNumber = parcel.Recipient.PhoneNumber,
                        Address = parcel.Recipient.Address
                    }
                };

                foreach (TrackingEvent trackingEvent
                    in parcel.TrackingHistory)
                {
                    parcelData.TrackingHistory.Add(
                        new TrackingEventData
                        {
                            Status = trackingEvent.Status,
                            Location = trackingEvent.Location,
                            Timestamp = trackingEvent.Timestamp,
                            Description = trackingEvent.Description
                        });
                }

                data.Add(parcelData);
            }

            string json = JsonConvert.SerializeObject(
                data,
                Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(_filePath, json);
        }

        // Load parcels from JSON
        public List<Parcel> Load()
        {
            List<Parcel> parcels = new List<Parcel>();

            if (!File.Exists(_filePath))
                return parcels;

            string json = File.ReadAllText(_filePath);

            List<ParcelData> data =
                JsonConvert.DeserializeObject<List<ParcelData>>(json);

            if (data == null)
                return parcels;

            foreach (ParcelData item in data)
            {
                Contact sender = new Contact(
                    item.Sender.Name,
                    item.Sender.PhoneNumber,
                    item.Sender.Address);

                Contact recipient = new Contact(
                    item.Recipient.Name,
                    item.Recipient.PhoneNumber,
                    item.Recipient.Address);

                Parcel parcel = new Parcel(
                    item.TrackingNumber,
                    item.WeightKg,
                    sender,
                    recipient,
                    item.DeliveryServiceName,
                    item.RegisteredDate);

                foreach (TrackingEventData historyItem
                    in item.TrackingHistory)
                {
                    TrackingEvent trackingEvent = new TrackingEvent(
                        historyItem.Status,
                        historyItem.Location,
                        historyItem.Description,
                        historyItem.Timestamp);

                    parcel.AddTrackingEvent(trackingEvent);
                }

                parcels.Add(parcel);
            }

            return parcels;
        }

        // Data-transfer classes used for JSON serialization
        private class ParcelData
        {
            public string TrackingNumber { get; set; }
            public double WeightKg { get; set; }
            public ParcelStatus Status { get; set; }

            public string DeliveryServiceName { get; set; }
            public DateTime RegisteredDate { get; set; }

            public ContactData Sender { get; set; }
            public ContactData Recipient { get; set; }

            public List<TrackingEventData> TrackingHistory { get; set; }
                = new List<TrackingEventData>();
        }

        private class ContactData
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
        }

        private class TrackingEventData
        {
            public ParcelStatus Status { get; set; }
            public string Location { get; set; }
            public DateTime Timestamp { get; set; }
            public string Description { get; set; }
        }
    }
}