using System;

namespace Models.News
{
    public class ArticleFromWebService : IArticle
    {
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
    }
}
