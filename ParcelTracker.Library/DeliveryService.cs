
using System;

namespace ParcelTrack.Library;

public class DeliveryService
{
    public string ServiceName { get; }
    public double BaseFee { get; }
    public double RatePerKg { get; }

    public DeliveryService(
        string serviceName,
        double baseFee,
        double ratePerKg)
    {
        if (string.IsNullOrWhiteSpace(serviceName))
            throw new ArgumentException(
                "Service name is required.");

        if (baseFee < 0)
            throw new ArgumentOutOfRangeException(
                nameof(baseFee),
                "Base fee cannot be negative.");

        if (ratePerKg < 0)
            throw new ArgumentOutOfRangeException(
                nameof(ratePerKg),
                "Rate per kg cannot be negative.");

        ServiceName = serviceName;
        BaseFee = baseFee;
        RatePerKg = ratePerKg;
    }
}
