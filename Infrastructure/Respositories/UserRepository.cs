using Domain.Users;

namespace Infrastructure.Respositories;

public sealed class UserRepository(AppDbContext dbContext)
{
    private readonly AppDbContext _dbContext = dbContext;

    public void Insert(User user) => _dbContext.Set<User>().Add(user);
}
