using System;

namespace Articles
{
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

    class StartUp
    {
        static void Main(string[] args)
        {
            var articleData = Console.ReadLine()?.Split(",");
            if (articleData != null && articleData.Length == 3)
            {
                var article = new Article(articleData[0].Trim(), articleData[1].Trim(), articleData[2].Trim());

                int commandCount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                for (int commandIndex = 0; commandIndex < commandCount; commandIndex++)
                {
                    string[] command = Console.ReadLine()?.Split(":");
                    if (command == null || command.Length != 2)
                    {
                        throw new InvalidProgramException(nameof(command));
                    }

                    var methodName = command[0].Trim();
                    var methodArgument = command[1].Trim();

                    switch (methodName.ToLower())
                    {
                        case "edit":
                            article.Edit(methodArgument);
                            break;
                        case "changeauthor":
                            article.ChangeAuthor(methodArgument);
                            break;
                        case "rename":
                            article.Rename(methodArgument);
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine(article.ToString());
            }
        }
    }
}
