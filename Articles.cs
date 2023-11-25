using System;
using System.Collections.Generic;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}

public static class ArticleRepository
{
    private static List<Article> articles = new List<Article>();
    private static int nextId = 1;

    public static List<Article> GetAll()
    {
        return articles;
    }

    public static Article GetById(int id)
    {
        return articles.Find(a => a.Id == id);
    }

    public static void Add(Article article)
    {
        article.Id = nextId++;
        articles.Add(article);
    }
}
