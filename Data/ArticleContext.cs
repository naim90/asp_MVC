using Microsoft.EntityFrameworkCore;
using Article.Models;

namespace Article.Data
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options)
            : base(options)
        {
        }

        public DbSet<Articles> Articles { get; set; }
    }
}