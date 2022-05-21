using BizBot;
using Bot_Console.POCO;
using Thread = Bot_Console.POCO.Thread;

namespace Bot_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scrape scraper = new Scrape("https://a.4cdn.org/biz/catalog.json");
            scraper.scrapeChanAsync();
            Catalog catalog = scraper.catalog;

            Console.WriteLine(catalog.page);
            foreach (Thread thread in catalog.threads)
            {
                Console.WriteLine(thread.no);
                Console.WriteLine(thread.now);
                Console.WriteLine(thread.com);
                Console.WriteLine(thread.replies);
            }
            Console.WriteLine(catalog.last_modified);

        }
    }
}