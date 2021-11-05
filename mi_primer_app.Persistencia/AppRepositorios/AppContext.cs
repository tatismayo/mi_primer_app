using Microsoft.EntityFrameworkCore;
using mi_primer_app.Dominio;

namespace mi_primer_app.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public Dbset<Persona> Personas {get; set;}

        public Dbset<Paciente> Pacientes {get; set;}

        public Dbset<Medico> Medicos {get; set;}

        public Dbset<SignoVital> SignosVitales {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if ( !optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=Hospital2207208; Data Source= LAPTOP-N5N4CBFB\SQLEXPRESS; Integrated Security:true");
            }
        }
    }
}