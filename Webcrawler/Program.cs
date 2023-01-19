using Services;

namespace Webcrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Paginacao paginacao = new Paginacao();
            paginacao.CrawlUrl();
        }
    }
}
