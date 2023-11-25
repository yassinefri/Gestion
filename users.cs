using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
}

public static class UserRepository
{
    private static List<User> users = new List<User>();
    private static int nextId = 1;

    public static List<User> GetAll()
    {
        return users;
    }

    public static User GetById(int id)
    {
        return users.Find(u => u.Id == id);
    }

    public static void Add(User user)
    {
        user.Id = nextId++;
        users.Add(user);
    }
}
