using System;
using Glass.Mapper.Sc;
using Models.Addresses;

namespace Services.Addresses
{
    public class AddressService : IAddressService
    {
        private readonly ISitecoreContext _sitecoreContext;

        public AddressService(ISitecoreContext sitecoreContext)
        {
            _sitecoreContext = sitecoreContext;
        }

        public Address GetAddress(Guid id)
        {
            return _sitecoreContext.GetItem<Address>(id);
        }
    }
}
