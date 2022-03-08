using Microsoft.EntityFrameworkCore;

namespace AppMVC.Models
{
    public class Context : DbContext
    {
        public Context( DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Participantes> Participantes { get; set; }
        public DbSet<Pacotes> Pacotes { get; set; }
        public DbSet<AxParticipanteAtividade> AxParticipanteAtividades { get; set; }
        public DbSet<AxParticipantePacote> AxParticipantePacotes { get; set; }
        public DbSet<Atividades> Atividades { get; set; }
    }
}
