using System.Collections.Generic;
using Models.News;

namespace Services.News
{
    public interface INewsAggregator
    {
        string[] NewsServiceNames { get; set; }
        IEnumerable<IArticle> GetAllNews(bool asc = true); 
        void InitializeService(string serviceName);
    }
}
