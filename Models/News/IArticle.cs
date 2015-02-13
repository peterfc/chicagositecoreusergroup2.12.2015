using System;
using System.Xml.Serialization;

namespace Models.News
{
    public interface IArticle
    {
        string Author { get; set; }
        DateTime PublishDate { get; set; }
        string Headline { get; set; }
        string Body { get; set; }
    }
}
