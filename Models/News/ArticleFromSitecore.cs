using System;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Models.News
{
    public class ArticleFromSitecore : CustomItem, IArticle
    {
        public ArticleFromSitecore(Item innerItem) : base(innerItem) { }

        public static implicit operator ArticleFromSitecore(Item innerItem)
        {
            return new ArticleFromSitecore(innerItem); 
        }

        public string Author
        {
            get
            {
                return InnerItem["Author"];
            }

            set
            {
                InnerItem["Author"] = value;
            }
        }

        public DateTime PublishDate
        {
            get
            {
                var fld = InnerItem.Fields["Publish Date"];
                return fld != null ? ((DateField)fld).DateTime : DateTime.MinValue;
            }

            set
            {
                InnerItem["Publish Date"] = Sitecore.DateUtil.ToIsoDate(value);
            } 
        }

        public string Headline
        {
            get
            {
                return InnerItem["Headline"];
            }

            set
            {
                InnerItem["Headline"] = value;
            }
        }

        public string Body
        {
            get
            {
                return InnerItem["Body"];
            }

            set
            {
                InnerItem["Body"] = value;
            }
        }
    }
}
