using System;

using AngleSharp;

namespace getlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = args[0];
            var config = Configuration.Default.WithDefaultLoader();
            var document = BrowsingContext.New(config).OpenAsync(url);

        }
    }
}
