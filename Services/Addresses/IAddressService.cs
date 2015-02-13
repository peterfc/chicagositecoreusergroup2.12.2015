using System;
using Models.Addresses;

namespace Services.Addresses
{
    public interface IAddressService
    {
        Address GetAddress(Guid id);
    }
}
