using System;
using System.Collections.Generic;
using System.Text;


namespace ParcelTrack.Library;

public class Contact
{
    public string Name { get; }
    public string PhoneNumber { get; }
    public string Address { get; }

    public Contact(string name, string phoneNumber, string address)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required.");

        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("Phone number is required.");

        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Address is required.");

        Name = name;
        PhoneNumber = phoneNumber;
        Address = address;
    }
}

