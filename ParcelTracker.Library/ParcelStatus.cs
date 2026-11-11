using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTrack.Library;

public enum ParcelStatus
{
    Registered,
    PickedUp,
    InTransit,
    OutForDelivery,
    Delivered,
    Cancelled
}