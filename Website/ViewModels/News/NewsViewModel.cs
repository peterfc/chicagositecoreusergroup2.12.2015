using System.Collections.Generic;
using Models.News;

namespace Website.ViewModels.News
{
    public class NewsViewModel
    {
        public IEnumerable<IArticle> Articles { get; set; }
    }
}