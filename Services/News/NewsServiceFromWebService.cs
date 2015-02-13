using System.Collections.Generic;
using Models.News;
using Services.NewsWebServiceConsumer;

namespace Services.News
{
    public class NewsServiceFromWebService : INewsService
    {
        private readonly NewsWebService _newsConsumer;

        public NewsServiceFromWebService()
        {
            _newsConsumer = new NewsWebService();
        }

        public IEnumerable<IArticle> GetNews()
        {
            return _newsConsumer.GetNews();
        }
    }
}
