using System.Collections.Generic;
using System.Linq;
using Castle.Core.Internal;
using Models.News;

namespace Services.News
{
    public class NewsAggregator : INewsAggregator
    {
        public string[] NewsServiceNames { get; set; }

        private readonly INewsServiceFactory _newsServiceFactory;
        private readonly IDictionary<string, INewsService> _newsServices; 

        public NewsAggregator(INewsServiceFactory newsServiceFactory)
        {
            _newsServiceFactory = newsServiceFactory;
            _newsServices = new Dictionary<string, INewsService>();
        }

        public IEnumerable<IArticle> GetAllNews(bool asc = true)
        {
            var articles = new List<IArticle>();
            _newsServices.Values.ForEach(service => articles.AddRange(service.GetNews()));
            return asc ? articles.OrderByDescending(article => article.PublishDate) : articles.OrderBy(article => article.PublishDate);
        }

        public void InitializeService(string serviceName)
        {
            if (!_newsServices.ContainsKey(serviceName))
            {
                _newsServices.Add(serviceName, _newsServiceFactory.Create(serviceName));
            }
        }
    }
}
