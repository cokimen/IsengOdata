namespace OdataLearn.Data;

using Microsoft.EntityFrameworkCore;
using OdataLearn.Data.Entities;
 

public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> context) : base(context)
    {
 
    }
 
    public DbSet<Students> Students { get; set; }
}