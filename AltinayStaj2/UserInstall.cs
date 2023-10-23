using AltinayStaj2.Models;
using System;
using System.Linq;

public class UserInstall
{
    private readonly ApplicationDbContext _dbContext;

    public UserInstall(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void InstallUsers()
    {
        var users = new List<User>
        {
            new User
            {
                Name = "Emrullah Dere",
                Age = 23,
                Text = "years old"
            },

        };

        foreach (var user in users)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Name == user.Name);


            if (existingUser == null)
            {
                _dbContext.Users.Add(user);
            }
            else
            {
                Console.WriteLine($"Kullanıcı {user.Name} zaten mevcut, eklenmedi.");
            }
        }

        try
        {
            _dbContext.SaveChanges();
            Console.WriteLine("Kullanıcılar başarıyla eklendi.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Kullanıcılar eklenirken bir hata oluştu: " + ex.Message);
        }
    }
}
