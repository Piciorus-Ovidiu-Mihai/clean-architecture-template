namespace Infrastructure.Persistence
{
    public class DataSeed
    {
        public static async Task Seed(ApplicationDbContext dbContext)
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
