using Microsoft.EntityFrameworkCore;


namespace WebAPI.Models
{
    public class CadastroDBContext : DbContext
    {
        public CadastroDBContext(DbContextOptions<CadastroDBContext> options) : base(options)
        {

        }

        public DbSet<Cadastro> Cadastros { get; set; }
    }
}
