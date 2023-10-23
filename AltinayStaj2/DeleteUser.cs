using Microsoft.EntityFrameworkCore;
using AltinayStaj2.Models;
using System;
using System.Linq;

public class DeleteUser
{
    private readonly ApplicationDbContext _dbContext;

    public DeleteUser(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void RemoveUser(int userId)
    {
        var user = _dbContext.Users.Find(userId);
        if (user != null)
        {
            _dbContext.Users.Remove(user);

            try
            {
                _dbContext.SaveChanges();
                Console.WriteLine("Kullanıcı başarıyla silindi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kullanıcı silinirken bir hata oluştu: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Belirtilen ID ile kullanıcı bulunamadı.");
        }
    }
}
