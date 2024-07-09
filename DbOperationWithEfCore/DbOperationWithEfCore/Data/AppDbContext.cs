using Microsoft.EntityFrameworkCore;
namespace DbOperationWithEfCore.Data

{
    public class AppDbContext : DbContext
    {
        //to not use hard code and configure all setting to progrm.cs 
        //to push all the setting of AppDbContext to DbContext we use *base* keyword to send value from child constructor to parent const
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
