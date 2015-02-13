using Glass.Mapper.Sc.Configuration.Attributes;

namespace Models.Addresses
{
    [SitecoreType(TemplateId = "{BA4AE800-A2F3-4A24-BE68-3F3AF409EC7E}", AutoMap = true)]
    public class Address
    {
        public virtual string Name { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        [SitecoreField("Zip Code")]
        public virtual string ZipCode { get; set; }
    }
}
