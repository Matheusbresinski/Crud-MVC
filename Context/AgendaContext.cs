using Microsoft.EntityFrameworkCore;
using PROJETO_MVC.Models;

namespace PROJETO_MVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

    public DbSet<Contato> Contatos { get; set; }
    }
}