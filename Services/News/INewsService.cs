using System.Collections.Generic;
using Models.News;

namespace Services.News
{
    public interface INewsService
    {
        IEnumerable<IArticle> GetNews();
    }
}
