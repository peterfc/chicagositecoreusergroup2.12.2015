

namespace Services.News
{
    public interface INewsServiceFactory
    {
        INewsService Create(string name);
        void Release(INewsService newsService);
    }
}
