using System;

class Program
{
    static void Main()
    {
        // Exemple d'utilisation de la gestion des articles
        ArticleRepository.Add(new Article { Title = "Premier article", Content = "Contenu de l'article 1" });
        ArticleRepository.Add(new Article { Title = "Deuxième article", Content = "Contenu de l'article 2" });

        var allArticles = ArticleRepository.GetAll();
        foreach (var article in allArticles)
        {
            Console.WriteLine($"Article {article.Id}: {article.Title}");
        }

        // Exemple d'utilisation de la gestion des utilisateurs
        UserRepository.Add(new User { UserName = "Utilisateur1" });
        UserRepository.Add(new User { UserName = "Utilisateur2" });

        var allUsers = UserRepository.GetAll();
        foreach (var user in allUsers)
        {
            Console.WriteLine($"Utilisateur {user.Id}: {user.UserName}");
        }
        // Exemple d'utilisation de la gestion des articles
        var articleController = new ArticleController();

        // Create
        articleController.CreateArticle(new Article { Title = "Nouvel article", Content = "Contenu du nouvel article" });

        // Read all
        var allArticls = articleController.GetAllArticles();
        foreach (var article in allArticles)
        {
            Console.WriteLine($"Article {article.Id}: {article.Title}");
        }

        // Read by Id
        var articleById = articleController.GetArticleById(1);
        if (articleById != null)
        {
            Console.WriteLine($"Article trouvé par ID: {articleById.Id} - {articleById.Title}");
        }
        else
        {
            Console.WriteLine("Article non trouvé par ID");
        }

        // Update
        articleController.UpdateArticle(1, new Article { Title = "Article mis à jour", Content = "Contenu mis à jour" });
        var updatedArticle = articleController.GetArticleById(1);
        if (updatedArticle != null)
        {
            Console.WriteLine($"Article mis à jour: {updatedArticle.Id} - {updatedArticle.Title}");
        }
        else
        {
            Console.WriteLine("Article non trouvé après la mise à jour");
        }

        // Delete
        articleController.DeleteArticle(1);
        Console.WriteLine("Article supprimé");

        // Read all (après la suppression)
        var remainingArticles = articleController.GetAllArticles();
        foreach (var article in remainingArticles)
        {
            Console.WriteLine($"Article restant: {article.Id} - {article.Title}");
        }
    }
}
