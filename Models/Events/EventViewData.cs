using System;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Models.Events
{
    [SitecoreType(TemplateId = "{0CAEF425-FA4E-4827-9F8E-EDA299C02395}", AutoMap = true)]
    public class EventViewData
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        [SitecoreField("Name Column Name")]
        public string NameColName { get; set; }
        [SitecoreField("Location Column Name")]
        public string LocationColName { get; set; }
        [SitecoreField("Date And Time Column Name")]
        public string DateTimeColName { get; set; }
        [SitecoreField("Description Column Name")]
        public string DescriptionColName { get; set; }
    }
}
