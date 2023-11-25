using System;
using System.Collections.Generic;
using System.Linq;

public class ArticleController
{
    public List<Article> GetAllArticles()
    {
        return ArticleRepository.GetAll();
    }

    public Article GetArticleById(int id)
    {
        return ArticleRepository.GetById(id);
    }

    public void CreateArticle(Article article)
    {
        ArticleRepository.Add(article);
    }

    public void UpdateArticle(int id, Article updatedArticle)
    {
        var existingArticle = ArticleRepository.GetById(id);

        if (existingArticle != null)
        {
            existingArticle.Title = updatedArticle.Title;
            existingArticle.Content = updatedArticle.Content;
        }
        else
        {
            throw new ArgumentException("Article not found");
        }
    }

    public void DeleteArticle(int id)
    {
        var existingArticle = ArticleRepository.GetById(id);

        if (existingArticle != null)
        {
            ArticleRepository.GetAll().Remove(existingArticle);
        }
        else
        {
            throw new ArgumentException("Article not found");
        }
    }
}
