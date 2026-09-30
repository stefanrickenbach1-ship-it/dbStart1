using DbStart1.Models;
using Microsoft.EntityFrameworkCore;

namespace DbStart1.Data;

public sealed class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    public DbSet<TodoItem> Todos => Set<TodoItem>();
}