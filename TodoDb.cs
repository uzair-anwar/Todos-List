using Microsoft.EntityFrameworkCore;
namespace Minimal_API
{
    class TodoDB: DbContext
    {
        public TodoDB(DbContextOptions<TodoDB> options):base(options) { }
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
