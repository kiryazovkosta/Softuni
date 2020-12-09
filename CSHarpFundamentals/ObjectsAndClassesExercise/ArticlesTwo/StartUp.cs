using System;

namespace ArticlesTwo
{
    using System.Collections.Generic;
    using System.Linq;

    public class Article
    {
        public Article(string titleParam, string contentParam, string authorParam)
        {
            this.Title = titleParam;
            this.Content = contentParam;
            this.Author = authorParam;
        }

        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var articles = CreateArticles();
            string criteria = Console.ReadLine()?.ToLower();
            var orderedArticles = OrderArticles(criteria, articles).ToList();
            foreach (var article in orderedArticles)
            {
                Console.WriteLine(article);
            }
        }

        private static IOrderedEnumerable<Article> OrderArticles(string criteria, IList<Article> articles)
        {
            IOrderedEnumerable<Article> orderedArticles = null;
            switch (criteria)
            {
                case "title":
                    orderedArticles = articles.OrderBy(x => x.Title);
                    break;
                case "content":
                    orderedArticles = articles.OrderBy(a => a.Content);
                    break;
                case "author":
                    orderedArticles = articles.OrderBy(a => a.Author);
                    break;
                default:
                    break;
            }

            return orderedArticles;
        }

        private static IList<Article> CreateArticles()
        {
            var articles = new List<Article>();
            var articleCount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int articleIndex = 0; articleIndex < articleCount; articleIndex++)
            {
                var articleData = Console.ReadLine()?.Split(",");
                if (articleData == null || articleData.Length != 3)
                {
                    throw new ArgumentException(nameof(articleData));
                }

                var article = new Article(articleData[0].Trim(), articleData[1].Trim(), articleData[2].Trim());
                articles.Add(article);
            }

            return articles;
        }
    }
}
