using System;
using Glass.Mapper.Sc.Configuration.Attributes;
using Models.Addresses;

namespace Models.Events
{
    [SitecoreType(TemplateId = "{270406C9-793C-420C-A64E-6F5384000B80}", AutoMap = true)]
    public class Event
    {
        public virtual string Name { get; set; }
        public virtual Guid Location { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Description { get; set; }

        [SitecoreIgnore]
        public Address Address { get; set; }
    }
}
