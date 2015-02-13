using System.Collections.Generic;
using System.Linq;
using Models.News;

namespace Services.News
{
    public class NewsServiceFromSitecore : INewsService
    {
        public IEnumerable<IArticle> GetNews()
        {
            var newsFolder = Sitecore.Context.Database.GetItem("{3EBADF99-3CAE-4B0D-9AD3-35B3F42A93D3}");
            return newsFolder.Children.Select(child => new ArticleFromSitecore(child));
        }
    }
}
