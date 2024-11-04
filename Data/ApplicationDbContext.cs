namespace SistemaDeContatos.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<ContatoModel> ContatoCadastro { get; set;} //Criando a tabela cadastro de contatos



    }
}
