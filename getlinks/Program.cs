using System;
using System.Linq;

using AngleSharp;
using AngleSharp.Dom;

namespace getlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = args[0];
            var config = Configuration.Default.WithDefaultLoader();
            var documentTask = BrowsingContext.New(config).OpenAsync(url);
            documentTask.RunSynchronously();

            var document = documentTask.Result;

            var links = for element in document.All
                select element;

            Console.ReadLine();
        }
    }
}
