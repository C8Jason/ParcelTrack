using System;

namespace ParcelTrack.Library
{
    public class ShippingCalculator
    {
        public double CalculateFee(
            double weightKg,
            DeliveryService service)
        {
            if (weightKg <= 0 ||
                double.IsNaN(weightKg) ||
                double.IsInfinity(weightKg))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(weightKg),
                    "Weight must be a valid positive number.");
            }

            if (service == null)
                throw new ArgumentNullException(nameof(service));

            // Fixed: Added '*' operator and removed stray hyphen
            double totalFee = service.BaseFee + (weightKg * service.RatePerKg);

            return totalFee;
        }
    }
}