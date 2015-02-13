using System.Web.Mvc;
using Services.News;
using Website.ViewModels.News;

namespace Website.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsAggregator _newsAggregator;

        public NewsController(INewsAggregator newsAggregator)
        {
            _newsAggregator = newsAggregator;
        }

        public ActionResult GetNews()
        {
            var viewModel = new NewsViewModel
            {
                Articles = _newsAggregator.GetAllNews(false)
            };
            return PartialView("News", viewModel);
        }
    }
}